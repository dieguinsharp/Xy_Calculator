using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xy_Calculator.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaSistemas : ContentPage {
        public TelaSistemas() {
            InitializeComponent();
        }
        private double x1, y1, num1, x2, y2, num2;
        public void CalcularSistemas(object sender, EventArgs args) {
            StackResolucao.Children.Clear();

            try {
                x1 = Convert.ToDouble(txtX.Text.Trim());
                y1 = Convert.ToDouble(txtY.Text.Trim());
                num1 = Convert.ToDouble(txtNum1.Text.Trim());

                x2 = Convert.ToDouble(txtX2.Text.Trim());
                y2 = Convert.ToDouble(txtY2.Text.Trim());
                num2 = Convert.ToDouble(txtNum2.Text.Trim());

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
                string[] r = Modelo.Formulas.Sistemas(x1, y1, num1, x2, y2, num2);

                Informacoes.Text = ":)";

                for(int x = 0; x < 5; x++) {
                    Label lbl = new Label() {
                        Text = r[x],
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 20,
                        TextColor = Color.Black,
                        FontFamily = "Architects Daughter"
                    };

                    StackResolucao.Children.Add(lbl);
                };

                ValorSolucao.Text = r[5];
            } catch(Exception ex) {
                DisplayAlert("Erro desconhecido:", ex.Message, "OK");
            }
        }
    }
}