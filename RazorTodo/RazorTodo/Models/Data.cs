using System;
using SQLite.Net.Attributes;

namespace RazorTodo
{
	public class Data
	{
		public Data ()
		{
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public DateTime Date { get; set; }
        public string Group { get; set; }
        public decimal Result { get; set; }
        public decimal Insulin { get; set; }
        public string Notes { get; set; }
	}
}

