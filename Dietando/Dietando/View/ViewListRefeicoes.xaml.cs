using System;
using System.Collections.Generic;


using Xamarin.Forms;

namespace Dietando
{
	public partial class ViewListRefeicoes : ContentPage
	{
		public ViewListRefeicoes ()
		{
			InitializeComponent ();

			MessagingCenter.Subscribe<string> (this, "DetailRefeicao", (sender) => {
				DisplayAlert("Aviso", "Clicou em um item: "+sender, "Ok");
			});
		}
	}
}

