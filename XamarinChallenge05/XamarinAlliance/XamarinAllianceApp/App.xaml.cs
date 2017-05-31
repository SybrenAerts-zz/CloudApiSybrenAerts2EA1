using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinAllianceApp.Views;

namespace XamarinAllianceApp
{
    public partial class App : Application
    {
        public static MobileServiceClient Client;

        public App()
        {
            InitializeComponent();

            string mobileServiceClientUrl = "https://xamarinalliancesecurebackend.azurewebsites.net";
            Client = new MobileServiceClient(mobileServiceClientUrl);

            // The root page of your application
            //MainPage = new NavigationPage(new CharacterListPage());
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public interface IAuthenticate
        {
            Task<bool> Authenticate();
        }

        public static IAuthenticate Authenticator { get; private set; }
        public static Task MobileStorageService { get; internal set; }

        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }
    }
}
