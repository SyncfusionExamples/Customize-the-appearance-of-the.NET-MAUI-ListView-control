using Syncfusion.Maui.ListView;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance_MAUI_ListView
{
	internal class ContactInfoDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate NormalTemplate { get; set; }
		public DataTemplate MissedCallTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var contact = (ContactInfo)item;
			if(contact != null)
			{
				if (contact.IsMissed)
					return MissedCallTemplate;
				else
					return NormalTemplate;
			}

			return NormalTemplate;
		}
	}
}
