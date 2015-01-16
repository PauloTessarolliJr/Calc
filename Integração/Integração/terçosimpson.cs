using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using YAMP;

namespace Integração
{
    class terçosimpson
    {
        private NumberStyles style;
        private CultureInfo culture;
        private Parser p;
        private string func;
        private double inicio, fim, h, funca, funcb,x1, funcx1;
        private double soma = 0;



        public terçosimpson(string func)
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

            h = (valorB - valorA)/2;
            inicio = valorA;
            x1 = valorA + h;
            fim = valorB;
            Parser.AddCustomConstant("x", (inicio));
            double.TryParse(p.Execute().ToString(), style, culture, out funca);
            Parser.AddCustomConstant("x", (x1));
            double.TryParse(p.Execute().ToString(), style, culture, out funcx1);
            Parser.AddCustomConstant("x", (fim));
            double.TryParse(p.Execute().ToString(), style, culture, out funcb);
            Console.WriteLine(h);
            Console.WriteLine();
            Console.WriteLine(fim);
            soma = (funcb + funca + 4* funcx1) * h / 3;
            return soma;

        }




    }
}
