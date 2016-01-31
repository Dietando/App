using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace Dietando
{
	[Table("tbItemRefeicao")]
	public class ItemRefeicao
	{
		[PrimaryKey]
		public int id { get; set; }
		public string item { get; set; }
		public float quantidade { get; set; }
		public string unidade { get; set; }
		public Boolean check { get; set; }

		[ForeignKey(typeof(ItemRefeicao))]
		public int idRefeicao { get; set; }
	}
}

