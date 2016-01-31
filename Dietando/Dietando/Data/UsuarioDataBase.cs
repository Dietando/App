using System;
using SQLite.Net;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Dietando
{
	public class UsuarioDataBase
	{
		SQLiteConnection database;
		static object locker = new object ();

		public UsuarioDataBase ()
		{
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			database.CreateTable<Usuario> ();
		}

		public IEnumerable<Usuario> GetItems ()
		{
			lock (locker) {
				return (from i in database.Table<Usuario> ()
				        select i).ToList ();
			}
		}

		public Usuario GetItem (int id)
		{
			lock (locker) {
				return database.Table<Usuario> ().FirstOrDefault (x => x.Id == id);
			}
		}

		public int DeleteItem (int id)
		{
			return database.Delete<Usuario> (id);
		}

		public int InsertUsuario (Usuario newUsuario)
		{
			lock (locker) {
				return database.Insert (newUsuario);
			}
		}
	}
}

