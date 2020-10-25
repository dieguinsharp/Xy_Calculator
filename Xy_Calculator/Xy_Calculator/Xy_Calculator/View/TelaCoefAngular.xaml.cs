using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xy_Calculator.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaCoefAngular : ContentPage {
        public TelaCoefAngular() {
            InitializeComponent();
        }

        private double x, y, x2, y2;

        public void CalcularCoeficiente(object sender, EventArgs args) {
            StackResolucao.Children.Clear();

            try {
                x = Convert.ToDouble(txtX.Text.Trim());
                y = Convert.ToDouble(txtY.Text.Trim());
                x2 = Convert.ToDouble(txtX2.Text.Trim());
                y2 = Convert.ToDouble(txtY2.Text.Trim());

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
                string[] r = Modelo.Formulas.CoeficienteAngular(x, y, x2, y2);

                Informacoes.Text = ":)";

                for(int x = 0; x < 1; x++) {
                    Label lbl = new Label() {
                        Text = r[x],
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 20,
                        TextColor = Color.Black,
                        FontFamily = "Architects Daughter"
                    };

                    StackResolucao.Children.Add(lbl);
                }

                ValorCoeficienteAngular.Text = r[1];

            } catch(Exception ex) {
                DisplayAlert("Erro desconhecido:", ex.Message, "OK");
            }
        }
    }
}