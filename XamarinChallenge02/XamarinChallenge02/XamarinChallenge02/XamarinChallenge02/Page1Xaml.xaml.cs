using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinChallenge02
{
    public partial class Page1Xaml : ContentPage
    {
        public Page1Xaml()
        {
            InitializeComponent();
        }

        async void ToPage2ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2Xaml());
        }   
    }
}
