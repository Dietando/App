using System;
using System.ComponentModel;

namespace Dietando.ViewModel
{
	public class BaseViewModel:INotifyPropertyChanged
	{
		public BaseViewModel ()
		{
		}

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChange (String prop)
		{
			if (PropertyChanged != null)
				PropertyChanged (this, new PropertyChangedEventArgs (prop));
		}

		#endregion
	}
}

