using Syncfusion.Maui.ListView;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance_MAUI_ListView
{
	public class IndexToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var listview = parameter as SfListView;
			var index = listview.DataSource.DisplayItems.IndexOf(value);

			if (index % 2 == 0)
				return Colors.LightGray;
			return Colors.Aquamarine;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}

}
