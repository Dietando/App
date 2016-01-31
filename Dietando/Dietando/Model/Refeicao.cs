using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace Dietando
{
	[Table("tbRefeicao")]
	public class Refeicao
	{
		[PrimaryKey]
		public int id { get; set; }
		public TimeSpan Horario { get; set; }
		public string Title { get; set; }
		public DateTime dataInicial { get; set; }
		public DateTime dataFinal { get; set; }
		public Boolean check { get; set; }

		[OneToMany]
		public List<ItemRefeicao> Itens { get; set;}
	}
}

