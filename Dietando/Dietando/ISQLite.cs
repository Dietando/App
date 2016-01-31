using System;
using SQLite.Net;

namespace Dietando
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

