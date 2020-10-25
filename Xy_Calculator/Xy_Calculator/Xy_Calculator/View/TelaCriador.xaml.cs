using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xy_Calculator.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaCriador : ContentPage {

        Uri uri;
        public TelaCriador() {
            InitializeComponent();
        }

        public void OnFacebook(object sender, EventArgs args) {
            try {
                uri = new Uri("https://www.facebook.com/MWStek/");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            } catch(Exception ex) {
                DisplayAlert("Erro : ", ex.Message, "Ok");
            }
        }

        public void OnInstagram(object sender, EventArgs args) {
            try {
                uri = new Uri("https://www.instagram.com/dieguinsharp/");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            } catch(Exception ex) {
                DisplayAlert("Erro : ", ex.Message, "Ok");
            }
        }

        public void OnGithub(object sender, EventArgs args) {
            try {
                uri = new Uri("https://github.com/dieguinsharp");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            } catch(Exception ex) {
                DisplayAlert("Erro : ", ex.Message, "Ok");
            }
        }
    }
}