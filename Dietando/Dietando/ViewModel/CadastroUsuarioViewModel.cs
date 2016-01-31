using System;

namespace Dietando.ViewModel
{
	public class CadastroUsuarioViewModel : BaseViewModel
	{
		private String _nome;
		public String Nome{
			get{ 
				return _nome;
			}
			set{ 
				_nome = value;
				NotifyPropertyChange ("Nome");
			}
		}

		private String _email;
		public String Email{
			get{
				return _email;
			}
			set{ 
				_email = value;
				NotifyPropertyChange ("Email");
			}
		}

		private String _senha;
		public String Senha{
			get{ 
				return _senha;
			}
			set{ 
				_senha = value;
				NotifyPropertyChange ("Senha");
			}
		}

		public CadastroUsuarioViewModel ()
		{
		}
	}
}

