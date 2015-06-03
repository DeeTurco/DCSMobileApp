using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Xamarin;

namespace DSHS.DCS.Droid
{
   [Activity(Label = "DSHS.DCS", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
   public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
   {
	  protected override void OnCreate(Bundle bundle)
	  {
		 base.OnCreate(bundle);

		 global::Xamarin.Forms.Forms.Init(this, bundle);

		 FormsMaps.Init(this, bundle);
		 LoadApplication(new App());
	  }
   }
}

