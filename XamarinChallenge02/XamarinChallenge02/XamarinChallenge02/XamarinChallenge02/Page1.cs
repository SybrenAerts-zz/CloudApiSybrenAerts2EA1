using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinChallenge02
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            var page2Button = new Button { Text = "Go to page2", VerticalOptions = LayoutOptions.CenterAndExpand };
            page2Button.Clicked += ToPage2ButtonClick;

            Title = "Page 01";
            Content = new StackLayout
            {
                Children = {
                    page2Button
                }
            };
        }

        async void ToPage2ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2()); //Push (go to next) page.
        }
    }
}
