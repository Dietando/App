using System;
using Dietando.iOS;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using Xamarin.Forms;

[assembly: Dependency (typeof(Dietando.iOS.SQLite_iOS))]

namespace Dietando.iOS
{
	public class SQLite_iOS: ISQLite
	{
		public SQLite_iOS ()
		{
		}

		#region ISQLite implementation

		public SQLiteConnection GetConnection ()
		{
			var sqliteFilename = "DataBaseDietando.db3";
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine (documentsPath, "..", "Library"); // Library folder
			var path = Path.Combine (libraryPath, sqliteFilename);

			// This is where we copy in the prepopulated database
			Console.WriteLine (path);
			if (!File.Exists (path)) {
				File.Copy (sqliteFilename, path);
			}
			var plataform = new SQLitePlatformIOS();
			var conn = new SQLiteConnection (plataform, path);

			// Return the database connection 
			return conn;
		}

		#endregion
	}
}

