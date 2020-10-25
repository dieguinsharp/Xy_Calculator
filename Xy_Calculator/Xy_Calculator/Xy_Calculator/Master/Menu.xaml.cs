using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xy_Calculator.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();

            Detail = new NavigationPage(new View.TelaBoasVindas());
        }

        public void OnInicio(object sender, EventArgs args)
        {
            App.Current.MainPage = new Master.Menu();
        }

        public void OnTelaDelta(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new View.TelaDelta());
            IsPresented = false;
        }

        public void OnTelaDistancia(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new View.TelaDistancia());
            IsPresented = false;
        }

        public void OnTelaPitagoras(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new View.TelaPitagoras());
            IsPresented = false;
        }

        public void OnTelaBaricentro(object sender, EventArgs args) {
            Detail = new NavigationPage(new View.TelaBaricentro());
            IsPresented = false;
        }

        public void OnTelaSistemas(object sender, EventArgs args) {
            Detail = new NavigationPage(new View.TelaSistemas());
            IsPresented = false;
        }

        public void OnAreaTriangulo(object sender, EventArgs args) {
            Detail = new NavigationPage(new View.TelaAreaTrianguloSARRI());
            IsPresented = false;
        }

        public void OnVerticeXY(object sender, EventArgs args) {
            Detail = new NavigationPage(new View.TelaVerticeXY());
            IsPresented = false;
        }

        public void OnCoeficienteAngular(object sender, EventArgs args) {
            Detail = new NavigationPage(new View.TelaCoefAngular());
            IsPresented = false;
        }

        public void OnPontoMedio(object sender, EventArgs args) {
            Detail = new NavigationPage(new View.TelaPontoMedio());
            IsPresented = false;
        }

        public void OnIconeInfo(object sender, EventArgs args) {
            Detail = new NavigationPage(new View.TelaCriador());
            IsPresented = false;
        }

        public void OnEquacaoDaReta(object sender, EventArgs args) {
            Detail = new NavigationPage(new View.TelaEquacaoDaReta());
            IsPresented = false;
        }

        public void OnEquacaoReduzida(object sender, EventArgs args) {
            Detail = new NavigationPage(new View.TelaEqReduzida());
            IsPresented = false;
        }

        public void OnCoefLinear(object sender, EventArgs args) {
            Detail = new NavigationPage(new View.TelaCoefLinear());
            IsPresented = false;
        }

    }
}