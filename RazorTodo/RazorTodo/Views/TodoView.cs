#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RazorTodo.Views
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#line 1 "TodoView.cshtml"
using RazorTodo;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "4.3.0.789")]
public partial class TodoView : TodoViewBase
{

#line hidden

#line 2 "TodoView.cshtml"
public RazorTodo.DataViewModel Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<html>\r\n<head>\r\n    <script");

WriteLiteral(" src=\"https://code.jquery.com/jquery-3.2.0.js\"");

WriteLiteral(" integrity=\"sha256-wPFJNIFlVY49B+CuAIrDr932XSb6Jk3J1M22M3E2ylQ=\"");

WriteLiteral(" crossorigin=\"anonymous\"");

WriteLiteral("></script>\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"style.css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"default.css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"default.date.css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"default.time.css\"");

WriteLiteral(" />\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"legacy.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"picker.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"picker.date.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"picker.time.js\"");

WriteLiteral("></script>\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\"");

WriteLiteral(" integrity=\"sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh" +
"4u\"");

WriteLiteral(" crossorigin=\"anonymous\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.cs" +
"s\"");

WriteLiteral(" integrity=\"sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/" +
"Sp\"");

WriteLiteral(" crossorigin=\"anonymous\"");

WriteLiteral(">\r\n    <script");

WriteLiteral(" src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\"");

WriteLiteral(" integrity=\"sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7T" +
"xa\"");

WriteLiteral(" crossorigin=\"anonymous\"");

WriteLiteral("></script>\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(">\r\n</head>\r\n<body>\r\n    <h1><a");

WriteLiteral(" href=\"hybrid:ListAll?\"");

WriteLiteral("><img");

WriteLiteral(" src=\"arrow.png\"");

WriteLiteral(" /></a> Todo</h1>\r\n    <form");

WriteLiteral(" action=\"hybrid:DataView\"");

WriteLiteral(" method=\"GET\"");

WriteLiteral(">\r\n        <input");

WriteLiteral(" name=\"id\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute ("value", " value=\"", "\""

#line 22 "TodoView.cshtml"
       , Tuple.Create<string,object,bool> ("", Model.ID

#line default
#line hidden
, false)
);
WriteLiteral(" />\r\n        <p>Date</p>\r\n        <input");

WriteLiteral(" name=\"date\"");

WriteLiteral(" type=\"text\"");

WriteAttribute ("value", " value=\"", "\""

#line 24 "TodoView.cshtml"
       , Tuple.Create<string,object,bool> ("", Model.Date

#line default
#line hidden
, false)
);
WriteLiteral(" class=\"datepicker\"");

WriteLiteral(" />\r\n        <p>Time</p>\r\n        <input");

WriteLiteral(" name=\"time\"");

WriteAttribute ("value", " value=\"", "\""

#line 26 "TodoView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.Time

#line default
#line hidden
, false)
);
WriteLiteral(" class=\"timepicker\"");

WriteLiteral(" />\r\n        <p>Result</p>\r\n        <input");

WriteLiteral(" name=\"result\"");

WriteAttribute ("value", " value=\"", "\""

#line 28 "TodoView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.Result

#line default
#line hidden
, false)
);
WriteLiteral(" />\r\n        <p>Insulin</p>\r\n        <input");

WriteLiteral(" name=\"insulin\"");

WriteAttribute ("value", " value=\"", "\""

#line 30 "TodoView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.Insulin

#line default
#line hidden
, false)
);
WriteLiteral(" />\r\n        <p>Note</p>\r\n        <input");

WriteLiteral(" name=\"notes\"");

WriteAttribute ("value", " value=\"", "\""

#line 32 "TodoView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.Notes

#line default
#line hidden
, false)
);
WriteLiteral(" />\r\n\r\n        <p>\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"Button\"");

WriteLiteral(" value=\"Save\"");

WriteLiteral(" />\r\n");


#line 36 "TodoView.cshtml"
            

#line default
#line hidden

#line 36 "TodoView.cshtml"
             if (Model.ID <= 0)
            {


#line default
#line hidden
WriteLiteral("                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"Button\"");

WriteLiteral(" value=\"Cancel\"");

WriteLiteral(" />\r\n");


#line 39 "TodoView.cshtml"
            }
            else {


#line default
#line hidden
WriteLiteral("                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"Button\"");

WriteLiteral(" value=\"Delete\"");

WriteLiteral(" />\r\n");


#line 42 "TodoView.cshtml"
            }


#line default
#line hidden
WriteLiteral(@"        </p>

    </form>
</body>
</html>

<script>
    $('.datepicker').pickadate({
        format: 'dd.mm.yyyy',
        formatSubmit: 'dd.mm.yyyy',
        selectYears: true,
        selectMonths: true
    });
    $('.timepicker').pickatime({
        // Escape any “rule” characters with an exclamation mark (!).
        format: 'HH:i',
        formatLabel: 'HH:i',
        formatSubmit: 'HH:i',
        interval: 5
    })
</script>");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class TodoViewBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		/// <summary>Executes the template and returns the output as a string.</summary>
		/// <returns>The template output.</returns>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString ();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		/// <summary>Executes the template, writing to the provided text writer.</summary>
		/// <param name="writer">The TextWriter to which to write the template output.</param>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
		/// <param name="value">The literal value.</param>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
		/// <param name="writer">The TextWriter to which to write the literal.</param>
		/// <param name="value">The literal value.</param>
		protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
		{
			writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
		/// <param name="writer">The TextWriter to which to write the value.</param>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value == null)
				return;

			var write = value as Action<System.IO.TextWriter>;
			if (write != null) {
				write (writer);
				return;
			}

			//NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
			//instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
			writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to the template output.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to a TextWriter.
		/// </summary>
		/// <param name="writer">The TextWriter to which to write the attribute.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		///<remarks>Used by Razor helpers to write attributes.</remarks>
		protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			// this is based on System.Web.WebPages.WebPageExecutingBase
			// Copyright (c) Microsoft Open Technologies, Inc.
			// Licensed under the Apache License, Version 2.0
			if (values.Length == 0) {
				// Explicitly empty attribute, so write the prefix and suffix
				writer.Write (prefix);
				writer.Write (suffix);
				return;
			}

			bool first = true;
			bool wroteSomething = false;

			for (int i = 0; i < values.Length; i++) {
				Tuple<string,object,bool> attrVal = values [i];
				string attPrefix = attrVal.Item1;
				object value = attrVal.Item2;
				bool isLiteral = attrVal.Item3;

				if (value == null) {
					// Nothing to write
					continue;
				}

				// The special cases here are that the value we're writing might already be a string, or that the
				// value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
				// of the string 'true'. If the value is the bool 'false' we don't want to write anything.
				//
				// Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
				string stringValue;
				bool? boolValue = value as bool?;
				if (boolValue == true) {
					stringValue = name;
				} else if (boolValue == false) {
					continue;
				} else {
					stringValue = value as string;
				}

				if (first) {
					writer.Write (prefix);
					first = false;
				} else {
					writer.Write (attPrefix);
				}

				if (isLiteral) {
					writer.Write (stringValue ?? value);
				} else {
					WriteTo (writer, stringValue ?? value);
				}
				wroteSomething = true;
			}
			if (wroteSomething) {
				writer.Write (suffix);
			}
		}
		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591
