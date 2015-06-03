using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DSHS.DCS
{
   public partial class FindOffice : ContentPage
   {
	  public FindOffice()
	  {

		 InitializeComponent();
	  }
	  void btnCurrentLocation(object sender, EventArgs e)
	  {

	  }
	  void btnSearch(object sender, EventArgs e)
	  {
		 App.Current.MainPage = new NavigationPage(new FindOfficeResult());
	  }
   }
}
