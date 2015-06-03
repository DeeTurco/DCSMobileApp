using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DSHS.DCS
{
   public class Main : ContentPage
   {
	  public Main()
	  {
		 Label header = new Label

		 {
			Text = "DSHS DCS",
			FontSize = 40,
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions = LayoutOptions.Center
		 };

		 Button btnContactUs = new Button
		 {
			Text = " Contact Us ",
			BackgroundColor = Color.FromHex("#3075AE"),
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BorderWidth = 1
		 };
		 btnContactUs.Clicked += async (sender, args) =>
			 await Navigation.PushAsync(new ContactUs());

		 Button btnEventCalendar = new Button
		 {
			Text = " Event Calendar ",
			BackgroundColor = Color.FromHex("#3075AE"),
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BorderWidth = 1
		 };
		 btnEventCalendar.Clicked += async (sender, args) =>
			 await Navigation.PushAsync(new EventCalendar());

		 Button btnEstimator = new Button
		 {
			Text = " Child Support Quick Estimator ",
			BackgroundColor = Color.FromHex("#3075AE"),
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BorderWidth = 1
		 };
		 btnEstimator.Clicked += async (sender, args) =>
			 await Navigation.PushAsync(new Estimator());

		 Button btnFindOffice = new Button
		 {
			Text = " Find ESA Office ",
			BackgroundColor = Color.FromHex("#3075AE"),
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BorderWidth = 1
		 };
		 btnFindOffice.Clicked += async (sender, args) =>
			 await Navigation.PushAsync(new FindOfficeResult());

		 // Build the page.
		 this.Content = new StackLayout
		 {
			Children = 
                {
                    header,
                    new StackLayout
                    {
					   BackgroundColor= Color.White,
                        HorizontalOptions = LayoutOptions.Center,
                        Children = 
                        {
                            btnContactUs,
                            btnEventCalendar,
                            btnEstimator,
                            btnFindOffice
                        }
                    }
                }
		 };
	  }
   }
}
