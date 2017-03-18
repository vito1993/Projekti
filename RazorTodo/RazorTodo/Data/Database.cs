using System;
using SQLite.Net;
using System.Collections.Generic;
using System.Linq;

namespace RazorTodo
{
	public class Database 
	{
		static object locker = new object ();

		SQLiteConnection database;

		/// <summary>
		/// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
		/// if the database doesn't exist, it will create the database and all the tables.
		/// </summary>
		/// <param name='path'>
		/// Path.
		/// </param>
		public Database(SQLiteConnection conn)
		{
			database = conn;
			// create the tables
			database.CreateTable<Data>();
		}

		public IEnumerable<Data> GetItems ()
		{
			lock (locker) {
				return (from i in database.Table<Data>() select i).ToList();
			}
		}

		public Data GetItem (int id) 
		{
			lock (locker) {
				return database.Table<Data>().FirstOrDefault(x => x.ID == id);
			}
		}

		public int SaveItem (Data item) 
		{
			lock (locker) {
				if (item.ID != 0) {
					database.Update(item);
					return item.ID;
				} else {
					return database.Insert(item);
				}
			}
		}

		public int DeleteItem(int id)
		{
			lock (locker) {
				return database.Delete<Data>(id);
			}
		}
	}
}

