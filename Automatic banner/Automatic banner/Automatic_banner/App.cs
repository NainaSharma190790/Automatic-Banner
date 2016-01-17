﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Automatic_banner
{
	public class App : Application
	{
        static public int ScreenWidth;
        static public int ScreenHeight;
		public App ()
		{
			// The root page of your application
            MainPage = new BannerView();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
