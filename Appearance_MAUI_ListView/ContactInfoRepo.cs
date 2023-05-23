using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance_MAUI_ListView
{
	internal class ContactInfoRepo
	{
		public ObservableCollection<ContactInfo> Contacts { get; set; }

		public ContactInfoRepo()
		{
			Contacts = GetContactDetails(20);
		}

		public ObservableCollection<ContactInfo> GetContactDetails(int count)
		{
			var contacts = new ObservableCollection<ContactInfo>();
			Random random = new Random();

			for(int i=0; i<count; i++)
			{
				var contact = new ContactInfo()
				{
					ContactName = CustomerNames[i],
					ContactImage = "image"+ i.ToString() + ".png",
					ContactNumber = random.Next(100, 400).ToString() + "-" + random.Next(500, 800).ToString() + "-" + random.Next(1000, 2000).ToString(),
				};
				if (i % 3 == 0 || i % 5 == 0)
				{
					contact.IsMissed = true;
				}
				contacts.Add(contact);
			}

			return contacts;
		}

		string[] CustomerNames = new string[]
		{
			"Kyle",
			"Gina",
			"Liz",
			"Larry",
			"Katie",
			"Liam",
			"Irene",
			"Michael",
			"Oscar",
			"Ralph",
			"Torrey",
			"William",
			"Bill",
			"Daniel",
			"Frank",
			"Brenda",
			"Danielle",
			"Fiona",
			"Howard",
			"Jack",
		};
	}
}
