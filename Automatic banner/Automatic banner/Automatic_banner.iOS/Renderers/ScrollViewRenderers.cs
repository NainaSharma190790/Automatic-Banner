using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using Automatic_banner.Controls;
using Automatic_banner.iOS;
[assembly: ExportRenderer(typeof(CustomScroll), typeof(ScrollViewRenderers))]

namespace Automatic_banner.iOS
{
    public class ScrollViewRenderers : ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            e.NewElement.PropertyChanging += OnElementPropertyChanged;
        }

      
        protected void OnElementPropertyChanged(object sender, PropertyChangingEventArgs e)
        {
            
        }
    }
}