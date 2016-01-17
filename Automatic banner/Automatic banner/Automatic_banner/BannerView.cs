using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace Automatic_banner
{
    public class BannerView : ContentPage
    {
        #region Field initialization
        //There is all filed initialization which we using on this page.
        public Image image, image2, image3, image4, image5, image6, image7, image8;
        public Label txt;
        public Button nextbtn, prebtn;
        public StackLayout bannerView,mainView;        public int iClicks = 0;

		string[] imgChange = new string[8];//This is image array. 
        int count = 1;
        public bool isFirst;
        #endregion

        public BannerView()
        {
            #region  All controls

            image = new Image
            {
                Source = imgChange[0],
                HorizontalOptions=LayoutOptions.FillAndExpand,
                HeightRequest = 150,
                WidthRequest = 320,
            };

            prebtn = new Button
            {
                BackgroundColor = Xamarin.Forms.Color.Transparent,
                HorizontalOptions = LayoutOptions.Start,
                WidthRequest = 50,
                Text="<<",
                TextColor=Xamarin.Forms.Color.White
            };
            prebtn.Clicked+=prebtn_Clicked;
            nextbtn = new Button
            {
                BackgroundColor = Xamarin.Forms.Color.Transparent,
                HorizontalOptions = LayoutOptions.End,
                WidthRequest = 50,
                Text = ">>",
                TextColor = Xamarin.Forms.Color.White
            };
            nextbtn.Clicked += nextbtn_Clicked;

            #endregion

            #region Main layout 

            bannerView = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Xamarin.Forms.Color.Transparent,
                HeightRequest=150,
                WidthRequest=320,
                Padding=new Thickness(0,0,0,0)
            };

            StackLayout SecondView = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Spacing = 200,
                BackgroundColor = Xamarin.Forms.Color.Transparent,
                Padding=new Thickness(10,0,10,0),
                Children =
                {
                    prebtn,nextbtn
                }
            };
            for (int i = imgChange.Length; i > 0; i--)
            {
                string source = "image" + i + ".png";
                image.Source = source;
                image.ClassId = "" + i + "";
                bannerView.Children.Add(image);
            }

            BackgroundImage = "Background.png";

            mainView = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions=LayoutOptions.Center,
                TranslationY =5,
                Spacing = 5,
                Children =
				{
                    new Label
                    {
                        Text="Automatic Banner",
                        TextColor=Xamarin.Forms.Color.Pink,
                        FontSize=30,
                        HorizontalOptions=LayoutOptions.Center
                    },
                   bannerView,
                   SecondView
                }
            };
            isFirst = true;
            Load();
            Content = mainView;
            #endregion
        }            
    
        #region Method for automatic slider

        public async void Load()
        {
            var eAndN = new Tuple<Easing, string>[]
                {
                    new Tuple<Easing, string> (Easing.Linear, "Linear") 
                };

            for (int i = 0; i < 100; i++)
            {
                if (count > 8)
                {
                    count = 1;
                }
               
                    image.Source = "";
                    string source = "image" + count + ".png";
                    image.ClassId = count.ToString();
                    image.Source = source;
                    count++;

                    double w = bannerView.Width;
                    double h = bannerView.Height;
                    var newPos = new Rectangle(0, 0, w, h);
                    var eAndName = eAndN[iClicks];
                    var easing = eAndName.Item1;
                    image.LayoutTo(newPos, 400, easing);
                    iClicks %= eAndN.Length;
                    bannerView.Padding = new Thickness(320, 0, 0, 0);
                

                Console.WriteLine("Working");
                await Task.Delay(10000);
                isFirst = false;
            }
        }
         
        
        #endregion
            
        #region All clicks

        void prebtn_Clicked(object sender, EventArgs e)
        {
            var eAndN = new Tuple<Easing, string>[]
             {
             new Tuple<Easing, string> (Easing.Linear, "Linear") 
             };
            if (count < 1)
            {
                count = 8;
            }

            string source = "image" + count + ".png";
            image.ClassId = count.ToString();
            image.Source = source;
            count--;

            double w = bannerView.Width+20;
            double h = bannerView.Height - 10;
            var newPos = new Rectangle(-5, 0, w, h);
            var eAndName = eAndN[iClicks];
            var easing = eAndName.Item1;
            image.LayoutTo(newPos, 400, easing);
            iClicks %= eAndN.Length;
            bannerView.Padding = new Thickness(-640, 0, 0, 0);
            Console.WriteLine("Pre");
           
            
        }

        void nextbtn_Clicked(object sender, EventArgs e)
        {
            var eAndN = new Tuple<Easing, string>[]
             {
             new Tuple<Easing, string> (Easing.Linear, "Linear") 
             };
            if (count > 8)
            {
                count = 1;
            }

            string source = "image" + count + ".png";
            image.ClassId = count.ToString();
            image.Source = source;
            count++;

            double w = bannerView.Width;
            double h = bannerView.Height;
            var newPos = new Rectangle(0, 0, w, h);
            var eAndName = eAndN[iClicks];
            var easing = eAndName.Item1;
            image.LayoutTo(newPos, 400, easing);
            iClicks %= eAndN.Length;
            bannerView.Padding = new Thickness(320, 0, 0, 0);

            Console.WriteLine("Next");
        }

        #endregion
    }
    
}
