using System;
using System.Collections.Generic;
using SQLite.Net;
using System.Linq;
using Xamarin.Forms;

namespace Dietando
{
	public class ItemRefeicaoDataBase
	{

		static object locker = new object ();
		SQLiteConnection database;

		public ItemRefeicaoDataBase ()
		{
			database = DependencyService.Get<ISQLite> ().GetConnection ();				
			database.CreateTable<ItemRefeicao> ();
		}

		public IEnumerable<ItemRefeicao> GetItems ()
		{
			lock (locker) {
				return (from i in database.Table<ItemRefeicao> ()
				        select i).ToList ();
			}
		}			

		public ItemRefeicao GetItem (int idItemRefeicao)
		{
			lock (locker) {
				return database.Table<ItemRefeicao> (). FirstOrDefault (x => x.id == idItemRefeicao);
			}
		}

		public int SaveItem (ItemRefeicao item)
		{
			lock (locker) {
				if (item.id != 0) {
					database.Update (item);
					return item.id;
				} else {
					return database.Insert (item);
				}
			}
		}

		public int DeleteItem (int id)
		{
			lock (locker) {
				return database.Delete<ItemRefeicao> (id);
			}
		}
	}
}