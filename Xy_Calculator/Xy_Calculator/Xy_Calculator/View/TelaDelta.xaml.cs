using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xy_Calculator.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaDelta : ContentPage {
        public TelaDelta() {
            InitializeComponent();
        }
        private double a, b, c;
        private void CalcularDelta(object sender, EventArgs args) {
            StackResolucao.Children.Clear();

            try {
                a = Convert.ToDouble(txtA.Text.Trim());
                b = Convert.ToDouble(txtB.Text.Trim());
                c = Convert.ToDouble(txtC.Text.Trim());
                Calcular();
            } catch(NullReferenceException) {
                Informacoes.TextColor = Color.Red;
                Informacoes.Text = "Valor inválido nas entradas, favor colocar 0 quando for nulo.";
            } catch(System.FormatException) {
                Informacoes.TextColor = Color.Red;
                Informacoes.Text = "Apenas valores numéricos!";
            }
        }

        public void Calcular() {
            try {
                string[] r = Modelo.Formulas.Delta(a, b, c);

                Informacoes.Text = r[3];

                for(int x = 0; x < 3; x++) {
                    Label lbl = new Label() {
                        Text = r[x],
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 20,
                        TextColor = Color.Black,
                        FontFamily = "Architects Daughter"
                    };

                    StackResolucao.Children.Add(lbl);
                };

                ValorDelta.Text = r[4];
                Valorx1x2.Text = "{" + r[5] + ", " + r[6] + "}";

            } catch(Exception ex) {
                DisplayAlert("Erro desconhecido:", ex.Message, "OK");

            }
        }
    }
}