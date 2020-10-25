using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xy_Calculator.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaBaricentro : ContentPage {
        public TelaBaricentro() {
            InitializeComponent();
        }
        private double x1, x2, x3, y1, y2, y3;
        public void CalcularBaricentro(object sender, EventArgs args) {
            StackResolucao.Children.Clear();

            try {
                x1 = Convert.ToDouble(txtX1.Text.Trim());
                y1 = Convert.ToDouble(txtY1.Text.Trim());
                x2 = Convert.ToDouble(txtX2.Text.Trim());
                y2 = Convert.ToDouble(txtY2.Text.Trim());
                x3 = Convert.ToDouble(txtX3.Text.Trim());
                y3 = Convert.ToDouble(txtY3.Text.Trim());

                Calcular();

            } catch(NullReferenceException) {
                Informacoes.TextColor = Color.Red;
                Informacoes.Text = "Valor inválido nas entradas, favor colocar 0 no lado que deseja procurar.";
            } catch(FormatException) {
                Informacoes.TextColor = Color.Red;
                Informacoes.Text = "Apenas valores numéricos!";
            }
        }

        public void Calcular() {
            try {
                string[] r = Modelo.Formulas.Baricentro(x1, y1, x2, y2, x3, y3);

                Informacoes.Text = ":)";

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
                ValorBaricentro.Text = r[3];
            }catch(Exception ex) {
                DisplayAlert("Erro desconhecido:", ex.Message, "OK");
            }
        }
    }
}