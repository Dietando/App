using System;
using SQLite.Net;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Dietando
{
	public class RefeicaoDataBase
	{
		static object locker = new object ();
		SQLiteConnection database;

		public RefeicaoDataBase ()
		{
			database = DependencyService.Get<ISQLite> ().GetConnection ();				
			database.CreateTable<Refeicao> ();
		}

		public IEnumerable<Refeicao> GetItems ()
		{
			lock (locker) {
				return (from i in database.Table<Refeicao> ()
				        select i).ToList ();
			}
		}

		public Refeicao GetItem (int id)
		{
			lock (locker) {
				return database.Table<Refeicao> ().FirstOrDefault (x => x.id == id);
			}
		}

		public int SaveItem (Refeicao item)
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
				return database.Delete<Refeicao> (id);
			}
		}

		public List<ItemRefeicao> GetListItensRefeicao (int id)
		{
			return database.Table<Refeicao> ().FirstOrDefault(x => x.id == id).Itens.ToList();
		}
	}
}