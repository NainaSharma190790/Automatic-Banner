using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Automatic_banner.Droid
{
	[Activity (Label = "Automatic_banner", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new Automatic_banner.App ());
            App.ScreenHeight = (int)(Resources.DisplayMetrics.WidthPixels);
            App.ScreenHeight = (int)(Resources.DisplayMetrics.HeightPixels);
           
		}
	}
}

