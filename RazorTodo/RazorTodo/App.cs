using System;

namespace RazorTodo
{
	public static class App
	{
		static SQLite.Net.SQLiteConnection conn;
		static Database database;
		public static void SetDatabaseConnection (SQLite.Net.SQLiteConnection connection)
		{
			conn = connection;
			database = new Database (conn);
		}
		public static Database Database {
			get { return database; }
		}
	}
}

