using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xy_Calculator.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaVerticeXY : ContentPage {
        public TelaVerticeXY() {
            InitializeComponent();
        }

        private double a, b, delta;

        public void CalcularVertice(object sender, EventArgs args) {
            StackResolucao.Children.Clear();

            try {
                a = Convert.ToDouble(txtA.Text.Trim());
                b = Convert.ToDouble(txtB.Text.Trim());
                delta = Convert.ToDouble(txtDelta.Text.Trim());

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
                string[] r = Modelo.Formulas.VerticeXY(a, b, delta);

                Informacoes.Text = ":)";

                for(int x = 0; x < 2; x++) {
                    Label lbl = new Label() {
                        Text = r[x],
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 20,
                        TextColor = Color.Black,
                        FontFamily = "Architects Daughter"
                    };

                    StackResolucao.Children.Add(lbl);
                };

                ValorX.Text = r[3];
                ValorY.Text = r[4];


            } catch(Exception ex) {
                DisplayAlert("Erro desconhecido:", ex.Message, "OK");
            }
        }
    }
}