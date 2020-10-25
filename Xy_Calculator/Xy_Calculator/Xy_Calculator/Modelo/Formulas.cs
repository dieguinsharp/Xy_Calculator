using System;
using System.Collections.Generic;
using System.Text;

namespace Xy_Calculator.Modelo
{
    class Formulas
    {
        private static string[] resolucao;
        public static string[] Delta(double a, double b, double c)
        {
            resolucao = new string[7];

            double delta = (b * b) - 4 * a * c;
            resolucao[0] = string.Format("Δ = ({0} * {0}) - 4 * {1} * {2} = {3}", b, a, c, delta);
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            resolucao[1] = string.Format("x' = (- ({0}) + √{1}) / 2 * {2} = {3}", b, delta, a, x1);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            resolucao[2] = string.Format("x' = (- ({0}) - √{1}) / 2 * {2} = {3}", b, delta, a, x2);

            if(delta > 0)
            {
                resolucao[3] = "Como delta é > 0, a equação tem dois valores reais e distintos.";
            }else if(delta == 0)
            {
                resolucao[3] = "Como delta é = 0, a equação terá dois valores reais e distintos.";
            }else if (delta < 0)
            {
                resolucao[3] = "Como delta é < 0, a equação não possuirá valores reais.";
            }

            resolucao[4] = delta.ToString();
            resolucao[5] = x1.ToString();
            resolucao[6] = x2.ToString();


            return resolucao;
        }

        public static string[] DistanciaEntrePontos(double x1, double y1, double x2, double y2)
        {
            resolucao = new string[5];

            double d1 = (x2 - x1) * (x2 - x1);
            resolucao[0] = string.Format("(({0} - ({1})) * ({0} - ({1}))) = {2}", x2, x1, d1);

            double d2 = (y2 - y1) * (y2 - y1);
            resolucao[1] = string.Format("(({0} - ({1})) * ({0} - ({1}))) = {2}", y2, y1, d2);

            double d3 = d1 + d2;
            resolucao[2] = string.Format("√({0} + {1}) = {2}", d1, d2, d3);

            double distancia = Math.Sqrt((d3));
            resolucao[3] = string.Format("√({0}) = {1}", d3, distancia);

            resolucao[4] = distancia.ToString();
            return resolucao;
        }

        public static string[] Pitagoras(bool hip, double x, double y, double z)
        {
            resolucao = new string[5];

            double lado; 

            double c1 = (y * y);
            resolucao[0] = string.Format("(({0} * {0}) = {1}", y, c1);

            double c2 = (z * z);
            resolucao[1] = string.Format("(({0} * {0}) = {1}", z, c2);      

            if(hip) {
                double c3 = (c1 + c2);
                resolucao[2] = string.Format("({0}) + ({1}) = {2}", c1, c2, c3);

                lado = Math.Sqrt(c3);
                resolucao[3] = string.Format("√({0}) = {1}", c3, lado);
            } else {
                double c3 = (c1 - c2);
                resolucao[2] = string.Format("({0}) - ({1}) = {2}", c1, c2, c3);

                lado = Math.Sqrt(c3);
                resolucao[3] = string.Format("√({0}) = {1}", c3, lado);
            }
            resolucao[4] = lado.ToString();

            return resolucao;
        }

        public static string[] Baricentro(double x1, double y1, double x2, double y2, double x3, double y3) {
            resolucao = new string[4];

            double x = (x1 + x2 + x3) / 3;
            resolucao[0] = string.Format("({0} + {1} + {2}) / 3 = {3}", x1, x2, x3, x);
            double y = (y1 + y2 + y3) / 3;
            resolucao[1] = string.Format("({0} + {1} + {2}) / 3 = {3}", y1, y2, y3, y);
            resolucao[2] = string.Format("{0}, {1}", x, y);
            resolucao[3] = "{"+ x + ", " + y + "}";

            return resolucao;
        }

        public static string[] Sistemas(double x1, double y1, double num1, double x2, double y2, double num2) {
            resolucao = new string[6];

            double metade = ((y1 * num2) - (y2 * num1));
            resolucao[0] = string.Format("x = ({0} * {1}) - ({2} * {3}) = {4}", y1, num2, y2, num1, metade);

            double OtherMetade = ((y1 * x2) - (x1 * y2));
            resolucao[1] = string.Format("x = ({0} * {1}) - ({2} * {3}) = {4}", y1, x2, x1, y2, OtherMetade);

            double x = metade / OtherMetade;
            resolucao[2] = string.Format("x = ({0} / {1}) = {2}", metade, OtherMetade, x);

            double y = ((x1 * x) - num1) / - (y1);
            resolucao[3] = "Substituindo o valor de X:";
            resolucao[4] = string.Format("y = (({0} * {1}) - ({2})) / -({3}) = {4}", x1, x, num1, y1, y);

            resolucao[5] = "{" + x + ", " + y + "}";

            return resolucao;
        }

        public static string[] AreaTrianguloSARRI(double x1, double y1, double x2, double y2, double x3, double y3) {
            resolucao = new string[4];
            double c1 = (x1 * y2 * 1) + (y1 * 1 * x3) + (1 * x2 * y3);
            resolucao[0] = string.Format("AT = ({0} + {1} + 1) + ({2} * 1 * {3}) + (1 * {4} * {5}) = {6}", x1, y2, y1, x3, x2, y3, c1);

            double c2 = (-(x3 * y2 * 1)) + (-(y3 * 1 * x1)) + (-(1 * x2 * y1));
            resolucao[1] = string.Format("AT = (-({0} * 1 * {1}) + (-(1 * {2} * {3})) = {4}", y3, x1, x2, y1, c2);

            double modulo = c1 + c2;

            double AT = (modulo < 0) ? modulo * -1 : modulo;

            AT = AT / 1 / 2;

            resolucao[2] = string.Format("AT = |({0} + {1})| / (1/2) = {2}", c1, c2, AT);

            resolucao[3] = AT.ToString();

            return resolucao;
        }

        public static string[] VerticeXY(double a, double b, double delta) {
            resolucao = new string[5];

            double Vx = (-b) / (2 * a);
            resolucao[0] = string.Format("Vx = (- ({0})) / (2 * {1}) = {2}", b, a, Vx);

            double Vy = (-delta) / (4 * a);
            resolucao[1] = string.Format("Vy = (- ({0})) / (4 * {1}) = {2}", delta, a, Vy);

            resolucao[3] = Vx.ToString();
            resolucao[4] = Vy.ToString();

            return resolucao;
        }

        public static string[] CoeficienteAngular(double x, double y, double x2, double y2) {
            resolucao = new string[2];

            resolucao[0] = string.Format("CA = (({0})-({1})) / (({2})-({3}))", y2, y, x2, x);

            double ca = ((y2) - (y));
            resolucao[1] = ca.ToString();

            ca = ((x2) - (x));
            resolucao[1] += " / " + ca.ToString();

            return resolucao;
        }

        public static string[] PontoMedio(double x1, double y1, double x2, double y2) {
            resolucao = new string[3];

            double x = (x1 + x2) / 2;
            resolucao[0] = string.Format("({0} - {1}) / 2 = {2}", x1, x2, x);

            double y = (y1 + y2) / 2;
            resolucao[1] = string.Format("({0} - {1}) / 2 = {2}", y1, y2, y);

            resolucao[2] = "{" + x + ", " + y + " }";
            return resolucao;
        }

        public static string[] EquacaoDaReta(double x1, double y1, double x2, double y2) {
            resolucao = new string[2];

            double x = (y1 * 1);
            double y = (1 * x2);
            double num = (1 * x1 * y2);

            double x_2= (-(y2 * 1));     
            double y_2 = (-(1 * x1));
            double num2 = (-(x2 * y1 * 1));

            resolucao[0] = string.Format("Eq = {0}x + ({1}x) + ({2}y) + ({3}y) + ({4}) + ({5}) = 0", x, x_2, y, y_2, num, num2);

            x += x_2;
            y += y_2;
            num += num2;

            if(y >= 0 && num >= 0) {
                resolucao[1] = string.Format("Eq = {0}x + {1}y + {2}", x, y, num);
            } else if(y <= 0 && num <= 0) {
                resolucao[1] = string.Format("Eq = {0}x {1}y {2}", x, y, num);
            } else if(y >= 0 && num <= 0) {
                resolucao[1] = string.Format("Eq = {0}x + {1}y {2}", x, y, num);
            } else if(y <= 0 && num >= 0) {
                resolucao[1] = string.Format("Eq = {0}x {1}y + {2}", x, y, num);
            }


            return resolucao;
        }

        public static string[] EquacaoReduzida(double x, double y, double coef) {
            resolucao = new string[6];

            resolucao[2] = "Formula Eq. Reduzida: y = mx + n";
            resolucao[0] = "m = " + coef;

            double n = y - (coef * x);
            resolucao[1] = string.Format("n = {0} - ({1} * {2}) = {3}", y, coef, x, n);

            resolucao[3] = "Substituindo:";
            resolucao[4] = string.Format("y = {0}x + ({1})", coef, n);

            resolucao[5] = string.Format("y = {0}x + ({1})", coef, n);

            return resolucao;
        }

        public static string[] CoeficienteLinear(double x, double y, double coef) {
            resolucao = new string[2];

            double n = y - (coef * x);
            resolucao[0] = string.Format("{0} - ({1} * {2}) = {3}", y, coef, x, n);

            resolucao[1] = n.ToString();

            return resolucao;
        }

    }
}
