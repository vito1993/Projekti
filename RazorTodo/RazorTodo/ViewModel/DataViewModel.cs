using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorTodo
{
    public class DataViewModel
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Group { get; set; }
        public decimal Result { get; set; }
        public decimal Insulin { get; set; }
        public string Notes { get; set; }
    }
}
