using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xy_Calculator.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaCoefLinear : ContentPage {
        public TelaCoefLinear() {
            InitializeComponent();
        }

        private double x, y, coef;

        public void OnCalcularLinear(object sender, EventArgs args) {
            StackResolucao.Children.Clear();

            try {
                x = Convert.ToDouble(txtX1.Text.Trim());
                y = Convert.ToDouble(txtY1.Text.Trim());
                coef = Convert.ToDouble(txtCoeficiente.Text.Trim());
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
                string[] r = Modelo.Formulas.CoeficienteLinear(x, y, coef);

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
                };

                ValorLinear.Text = r[1];
            } catch(Exception ex) {
                DisplayAlert("Erro desconhecido:", ex.Message, "OK");

            }
        }
    }
}