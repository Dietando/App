using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Dietando.ViewModel
{
	public class ListRefeicoesViewModel : BaseViewModel
	{
		private List<string> _listrefeicoes = new List<string>(){
			"07:00 - Café da manhã",
			"10:00 - Lanche",
			"12:00 - Almoço",
			"15:00 - Lanche",
			"18:00 - Jantar",
			"21:00 - Ceia",	
		};
		public List<string> ListRefeicoes{
			get{
				return _listrefeicoes;
			}
			set {
				_listrefeicoes = value;
				NotifyPropertyChange ("ListRefeicoes");
			}
		}

		private ListView _listview;
		public ListView ListView{
			get{
				return _listview;
			}

			set{
				_listview = value;
				NotifyPropertyChange ("ListView");
			}

		}

		private String _onItemSelected;
		public String OnItemSelected{
			get{ 
				return _onItemSelected;
			}
			set{ 
				if (value != null)
					MessagingCenter.Send<string> (value, "DetailRefeicao");
			}
		}

		public ListRefeicoesViewModel ()
		{
			 
		}
	}
}

