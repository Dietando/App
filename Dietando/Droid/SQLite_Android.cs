using System;
using System.IO;
using Dietando.Droid;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;

[assembly: Xamarin.Forms.Dependency (typeof (SQLite_Android))]

namespace Dietando.Droid
{
	public class SQLite_Android : ISQLite
	{
		public SQLite_Android ()
		{
		}

		#region ISQLite implementation

		public SQLiteConnection GetConnection ()
		{
			var sqliteFilename = "DataBaseDietando.db3";
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine (documentsPath, "..", "Library"); // Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);
			var plataform = new SQLitePlatformAndroid ();
			// Create the connection
			var conn = new SQLiteConnection(plataform,path);
			// Return the database connection
			return conn;
		}

		#endregion

	}
}

