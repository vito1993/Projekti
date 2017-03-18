using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;
using RazorTodo.Views;

namespace RazorTodo
{
    public class RazorWebViewClient : WebViewClient
    {

        Context context;
        public RazorWebViewClient(Context context)
        {
            this.context = context;
        }
        public override bool ShouldOverrideUrlLoading(WebView webView, string url)
        {
            var scheme = "hybrid:";
            // If the URL is not our own custom scheme, just let the webView load the URL as usual
            if (!url.StartsWith(scheme))
                return false;

            // This handler will treat everything between the protocol and "?"
            // as the method name.  The querystring has all of the parameters.
            var resources = url.Substring(scheme.Length).Split('?');
            var method = resources[0];
            var parameters = System.Web.HttpUtility.ParseQueryString(resources[1]);


            if (method == "ListAll")
            {
                var model = App.Database.GetItems().ToList();
                List<List<Data>> lista = model
                .GroupBy(u => u.Group)
                .Select(grp => grp.ToList())
                .ToList();
                var template = new TodoList() { Model = lista };
                var page = template.GenerateString();
                webView.LoadDataWithBaseURL("file:///android_asset/", page, "text/html", "UTF-8", null);
            }
            else if (method == "AddTask")
            {
                var template = new TodoView() { Model = new DataViewModel { Time = DateTime.Now.ToString("HH:mm"), Date = DateTime.Now.ToString("dd.MM.yyyy") } };
                var page = template.GenerateString();
                webView.LoadDataWithBaseURL("file:///android_asset/", page, "text/html", "UTF-8", null);
            }
            else if (method == "ViewTask")
            {
                var id = parameters["todoid"];
                var data = App.Database.GetItem(Convert.ToInt32(id));
                var model = new DataViewModel();
                model.ID = data.ID;
                model.Insulin = data.Insulin;
                model.Result = data.Result;
                model.Date = data.Date.ToString("dd.MM.yyyy");
                model.Time = data.Date.ToString("HH.mm");
                model.Notes = data.Notes;
                var template = new TodoView() { Model = model };
                var page = template.GenerateString();
                webView.LoadDataWithBaseURL("file:///android_asset/", page, "text/html", "UTF-8", null);
            }

            else if (method == "DataView")
            {
                // the editing form
                var button = parameters["Button"];
                if (button == "Save")
                {
                    var id = parameters["id"];
                    var date = parameters["date"];
                    var result = parameters["result"];
                    var notes = parameters["notes"];
                    var time = parameters["time"];

                    var dateArray = date.Split('.');
                    var timeArray = time.Split(':');
                    var todo = new Data
                    {
                        ID = Convert.ToInt32(id),
                        Date = new DateTime(int.Parse(dateArray[2]), int.Parse(dateArray[1]), int.Parse(dateArray[0]), int.Parse(timeArray[0]), int.Parse(timeArray[1]), 0),
                        Result = Decimal.Parse(result),
                        Notes = notes,
                        Group = date
                    };

                    App.Database.SaveItem(todo);

                    var model = App.Database.GetItems().ToList();

                    List<List<Data>> lista = model
                    .GroupBy(u => u.Group)
                    .Select(grp => grp.ToList())
                    .ToList();

                    var template = new TodoList() { Model = lista };
                    var page = template.GenerateString();
                    webView.LoadDataWithBaseURL("file:///android_asset/", page, "text/html", "UTF-8", null);
                }
                else if (button == "Delete")
                {
                    var id = parameters["id"];

                    App.Database.DeleteItem(Convert.ToInt32(id));

                    var model = App.Database.GetItems().ToList();
                    List<List<Data>> lista = model
                    .GroupBy(u => u.Group)
                    .Select(grp => grp.ToList())
                    .ToList();

                    var template = new TodoList() { Model = lista };
                    var page = template.GenerateString();
                    webView.LoadDataWithBaseURL("file:///android_asset/", page, "text/html", "UTF-8", null);
                }
                else if (button == "Cancel")
                {
                    var model = App.Database.GetItems().ToList();
                    List<List<Data>> lista = model
                    .GroupBy(u => u.Group)
                    .Select(grp => grp.ToList())
                    .ToList();
                    var template = new TodoList() { Model = lista };
                    var page = template.GenerateString();
                    webView.LoadDataWithBaseURL("file:///android_asset/", page, "text/html", "UTF-8", null);
                }
            }


            return true;
        }
    }
}

