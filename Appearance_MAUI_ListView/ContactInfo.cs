using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance_MAUI_ListView
{
	internal class ContactInfo: INotifyPropertyChanged
	{
		public string ContactName { get; set; }
		public string ContactImage { get; set; }
		public string ContactNumber { get; set; }
		public bool IsMissed { get; set; }

		private bool isExpanded = false;
		public bool IsExpanded
		{
			get { return isExpanded; }
			set
			{
				isExpanded = value;
				this.RaisedOnPropertyChanged("IsExpanded");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void RaisedOnPropertyChanged(string _PropertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
			}
		}
	}
}
