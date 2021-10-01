using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Opdracht02
{
    public class StartPage : MasterDetailPage
    {
        public StartPage()
        {
            Master = new ContentPage
            {
                Title = "Master",
                Content = new StackLayout
                {
                    Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
                }
            };

            Detail = new MainPage();
        }
    }
}