using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using YAMP;

namespace WindowsFormsApplication1
{
    class Derivada
    {
        private readonly double e = 0.0001;
        private readonly int diminui = 2;
        private NumberStyles style;
        private CultureInfo culture;
        private Parser p;
        private int contador;
        private string func;
        private double erro;
        private double h;

        private double maisH, menosH;
        private double valorAtual, valorAnterior;

        public Derivada(string func)
        {
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("en-GB");
            this.func = func;
            this.h = 0.5f;
            this.contador = 0;
            this.erro = 1;
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

        public double Calcula(double valor)
        {
            while (erro > e)
            {
                this.contador++;
                this.valorAnterior = this.valorAtual;
                Parser.AddCustomConstant("x", (valor + this.h));
                double.TryParse(p.Execute().ToString(), style, culture, out maisH);
                Parser.AddCustomConstant("x", (valor - this.h));
                double.TryParse(p.Execute().ToString(), style, culture, out menosH);
                valorAtual = (maisH - menosH) / (2 * this.h);
                if (contador > 1)
                    erro = Math.Abs((valorAnterior - valorAtual) / (Math.Max(1, valorAtual)));
                this.h /= diminui;
                //Console.WriteLine(valorAtual.ToString());
            }
            return valorAtual;
        }

    }
}
