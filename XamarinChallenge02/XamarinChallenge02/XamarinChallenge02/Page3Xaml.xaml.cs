using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinChallenge02
{
    public partial class Page3Xaml : ContentPage
    {
        public Page3Xaml()
        {
            InitializeComponent();
        }

        async void ToPage2ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void ToPage1ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
