using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DSHS.DCS
{
   public partial class FindOfficeResult : ContentPage
   {
	  public FindOfficeResult()
	  {
		 var groups = Data.OfficeLocation.OLocation
				.OrderBy(c => c.OfficeCity)
				.GroupBy(c => c.OfficeCity[0].ToString(), c => c).ToList();


		 var groupedElements = groups.Select(g => new ObservableGrouping<Data.OfficeMetadata>(Data.OfficeLocation.OLocation, g.Key, g)).ToList();

		
		 BindingContext = groupedElements;

		 InitializeComponent();
		
	  }
	  async void OnItemTapped(object sender, ItemTappedEventArgs e)
	  {
		 Data.OfficeMetadata officeMetadata = (Data.OfficeMetadata)e.Item;

		 await this.Navigation.PushAsync(new OfficeDetails(officeMetadata));
	  }

	  //async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	  //{
	  //   ((ListView)sender).SelectedItem = null;
	  //}
   }
}
