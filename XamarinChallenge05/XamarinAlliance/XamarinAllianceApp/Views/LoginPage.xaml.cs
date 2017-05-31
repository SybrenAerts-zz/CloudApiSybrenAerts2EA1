using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinAllianceApp.Helpers;

namespace XamarinAllianceApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public static MobileServiceClient Service = new MobileServiceClient("http://xamarinalliancebackend.azurewebsites.net");

        bool authenticated;

        public object CREDITAPI { get; private set; }
        public object image { get; private set; }

        async void loginButton_Clicked(object sender, EventArgs e)
        {
            if (App.Authenticator != null)
                authenticated = await App.Authenticator.Authenticate();

            // Set syncItems to true to synchronize the data on startup when offline is enabled.
            if (authenticated == true)
                await Navigation.PushAsync(new CharacterListPage());
        }

        async void blobButton_Clicked(object sender, EventArgs e)
        {
            var client = new MobileServiceClient(Constants.MobileServiceClientUrl);
            var token = await client.InvokeApiAsync("/api/StorageToken/CreateToken");

            string storageAccountName = "xamarinalliance";

            StorageCredentials credentials = new StorageCredentials(Convert.ToString(token));

            CloudStorageAccount account = new CloudStorageAccount(credentials, storageAccountName, null, true);

            //client = account.CreateCloudBlobClient();


            ///////////////////////////////////////////////////////////////////////////

            var container = client.GetContainerReference("images");
            var blob = container.GetBlobReference("XAMARIN-Alliance-logo.png");

            //MemoryStream stream = new MemoryStream();

            //await blob.DownloadToStreamAsync(stream);

        }
    }
}
