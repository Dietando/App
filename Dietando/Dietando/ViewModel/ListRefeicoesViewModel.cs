using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Dietando.ViewModel
{
	public class ListRefeicoesViewModel : BaseViewModel
	{
		
		private ObservableCollection<Refeicao> _listrefeicoes = new ObservableCollection<Refeicao>(){
			new Refeicao{
				id = 1, Horario = new TimeSpan(7,0,0), Title = "Café da Manhã", dataInicial = new DateTime(2016, 1, 31), dataFinal = new DateTime(2016, 3, 31), check = false
			},
			new Refeicao{
				id = 2, Horario = new TimeSpan(7,0,0), Title = "Café da Manhã", dataInicial = new DateTime(2016, 1, 31), dataFinal = new DateTime(2016, 3, 31), check = false
			},
			new Refeicao{
				id = 3, Horario = new TimeSpan(7,0,0), Title = "Café da Manhã", dataInicial = new DateTime(2016, 1, 31), dataFinal = new DateTime(2016, 3, 31), check = false
			},
			new Refeicao{
				id = 4, Horario = new TimeSpan(7,0,0), Title = "Café da Manhã", dataInicial = new DateTime(2016, 1, 31), dataFinal = new DateTime(2016, 3, 31), check = false
			},
			new Refeicao{
				id = 5, Horario = new TimeSpan(7,0,0), Title = "Café da Manhã", dataInicial = new DateTime(2016, 1, 31), dataFinal = new DateTime(2016, 3, 31), check = false
			},
			new Refeicao{
				id = 6, Horario = new TimeSpan(7,0,0), Title = "Café da Manhã", dataInicial = new DateTime(2016, 1, 31), dataFinal = new DateTime(2016, 3, 31), check = false
			},
			

		};
		public ObservableCollection<Refeicao> ListRefeicoes{
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

