using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Automatic_banner.Droid;
using Automatic_banner.Controls;

[assembly: ExportRenderer(typeof(CustomList), typeof(CustomListRenderer))]
namespace Automatic_banner.Droid
{
    public class CustomListRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);
            Control.VerticalScrollBarEnabled = true;
            Control.DividerHeight = 0;   
            

        }
       
    }
}