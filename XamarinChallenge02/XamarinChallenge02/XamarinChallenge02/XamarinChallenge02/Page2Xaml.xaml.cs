using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinChallenge02
{
    public partial class Page2Xaml : ContentPage
    {
        public Page2Xaml()
        {
            InitializeComponent();
        }

        async void ToPage3ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3Xaml());
        }

        async void ToPage1ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
