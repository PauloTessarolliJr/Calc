using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using YAMP;

namespace Integração
{
    class retangulo
    {
        private NumberStyles style;
        private CultureInfo culture;
        private Parser p;
        private string func;
        private double inicio, fim, intervalo,h;
        private double soma = 0, resultado = 0;



        public retangulo(string func)
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
            h = 0.0001;
            inicio = valorA;
            fim = valorB;
            intervalo = h;
            do
            {
                inicio = inicio + h;
                Parser.AddCustomConstant("x", (inicio));
                double.TryParse(p.Execute().ToString(), style, culture, out resultado);
                soma = soma + resultado;
            } while (inicio < fim);
            soma = soma * h;
            return soma;

        }
    
    
    
    
    }
}
