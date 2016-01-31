using System;
using SQLite.Net.Attributes;

namespace Dietando
{
	[Table("tbUsuario")]
	public class Usuario
	{
		[PrimaryKey]
		public int Id { get; set; }
		public string nome { get; set; }
		public string token { get; set; }
	}
}

