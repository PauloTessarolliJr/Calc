using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using YAMP;

namespace Integração
{
    class tresoitavossimpson
    {
        private NumberStyles style;
        private CultureInfo culture;
        private Parser p;
        private string func;
        private double inicio, fim, h, funca, funcb, valorX, funcx, aux, somamult, somanaomult,n, cont;
        private double soma = 0;



        public tresoitavossimpson(string func)
        {
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("en-GB");
            this.func = func;
            this.tryParse(this.func);
        }

        private bool tryParse(string func)
        {
            try
            {
                p = Parser.Parse(func);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public double Calcula(double valorA, double valorB)
        {
            n = 4;
            aux = h;
            inicio = valorA;
            valorX = valorA;

            fim = valorB;
            Parser.AddCustomConstant("x", (inicio));
            double.TryParse(p.Execute().ToString(), style, culture, out funca);
            Parser.AddCustomConstant("x", (fim));
            double.TryParse(p.Execute().ToString(), style, culture, out funcb);

            if (n % 3 != 0)
            {
                n = 3 * ((n / 3) + 1);
            }

            h = (valorB - valorA) / n;

            do
            {
                cont++;
                valorX = valorX + h;
                Parser.AddCustomConstant("x", (valorX));
                //Console.WriteLine(cont);
                double.TryParse(p.Execute().ToString(), style, culture, out funcx);
               if (cont % 3 == 0)
                {
                    somamult = somamult + funcx;
                    //Console.WriteLine(somamult);
                    //Console.WriteLine();
                    //Console.WriteLine(somanaomult);

                }
                else
                {
                    somanaomult = somanaomult + funcx;
                }
            } while (cont < (n -1));
            
            soma = (funca + funcb + 2 * somamult + 3 * somanaomult) * h * 3 / 8;
            return soma;

        }




    }
}
