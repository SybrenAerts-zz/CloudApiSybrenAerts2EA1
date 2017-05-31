using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinChallenge02
{
    public class Page3 : ContentPage
    {
        public Page3()
        {
            var page2Button = new Button { Text = "Go to page 2", VerticalOptions = LayoutOptions.CenterAndExpand };
            page2Button.Clicked += ToPage2ButtonClick;

            var page1Button = new Button { Text = "Go to page 1", VerticalOptions = LayoutOptions.CenterAndExpand };
            page1Button.Clicked += ToPage1ButtonClick;

            Title = "Page 03";
            Content = new StackLayout
            {
                Children = {
                    page2Button,
                    page1Button
                }
            };
        }

        async void ToPage2ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); //Go to previous page (page2).
        }

        async void ToPage1ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(); //Go to page 1 (root page)
        }
    }
}
