using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Dietando.ViewModel
{
	public class LoginViewModel:BaseViewModel
	{
		private string _email;
		public string Email{
			get{ 
				return _email;}
			set{ 
				_email = value;
				NotifyPropertyChange ("Email");
			}
		}

		private string _senha;
		public string Senha{
			get{ 
				return _senha;}
			set{ 
				_senha = value;
				NotifyPropertyChange ("Senha");
			}
		}

		public ICommand Acess { get; set; }

		public LoginViewModel ()
		{
			this.Acess = new Command (() => {
//				this.Email += this.Senha;
			});
		}
	}
}

