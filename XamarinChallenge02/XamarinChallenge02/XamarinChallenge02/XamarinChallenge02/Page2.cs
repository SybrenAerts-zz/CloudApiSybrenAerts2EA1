using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinChallenge02
{
    public class Page2 : ContentPage
    {
        public Page2()
        {
            var page3Button = new Button { Text = "Go to page3", VerticalOptions = LayoutOptions.CenterAndExpand };
            page3Button.Clicked += ToPage3ButtonClick;

            var page1Button = new Button { Text = "Go to page1", VerticalOptions = LayoutOptions.CenterAndExpand };
            page1Button.Clicked += ToPage1ButtonClick;

            Title = "Page 02";
                Content = new StackLayout
                {
                    Children = {
                    page3Button,
                    page1Button
                }
            };
        }

        async void ToPage3ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3()); //Push (go to next) page.
        }

        async void ToPage1ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); //Pop (go back) to previous page.
        }
    }
}

