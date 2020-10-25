using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xy_Calculator.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaPitagoras : ContentPage {
        public TelaPitagoras() {
            InitializeComponent();
        }

        private double a, b, c;

        public void CalcularPitagoras(object sender, EventArgs args) {
            StackResolucao.Children.Clear();

            try {
                a = Convert.ToDouble(txtA.Text.Trim());
                b = Convert.ToDouble(txtB.Text.Trim());
                c = Convert.ToDouble(txtC.Text.Trim());

                if(a == 0) {
                    Calcular(true, a, b, c);
                } else if(b == 0) {
                    Calcular(false, b, a, c);
                } else if(c == 0) {
                    Calcular(false, c, a, b);
                } else {
                    throw new NullReferenceException();
                }
            } catch(NullReferenceException) {
                Informacoes.TextColor = Color.Red;
                Informacoes.Text = "Valor inválido nas entradas, favor colocar 0 no lado que deseja procurar.";
            } catch(FormatException) {
                Informacoes.TextColor = Color.Red;
                Informacoes.Text = "Apenas valores numéricos!";
            }
        }

        public void Calcular(bool hip, double x, double y, double z) {
            try {
                string[] r = Modelo.Formulas.Pitagoras(hip, x, y, z);

                Informacoes.Text = ":)";

                for(int x2 = 0; x2 < 4; x2++) {
                    Label lbl = new Label() {
                        Text = r[x2],
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 20,
                        TextColor = Color.Black,
                        FontFamily = "Architects Daughter"
                    };

                    StackResolucao.Children.Add(lbl);
                };

                ValorPitagoras.Text = r[4];
            } catch(Exception ex) {
                DisplayAlert("Erro desconhecido:", ex.Message, "OK");


            }
        }
    }
}