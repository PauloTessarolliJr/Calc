﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using YAMP;

namespace Derivadas
{
    class DerivadaSegunda
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

        private double maisH, menosH, normal,normal2;
        private double valorAtual, valorAnterior;

        public DerivadaSegunda(string func)
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
                Parser.AddCustomConstant("x", (valor - this.h));
                double.TryParse(p.Execute().ToString(), style, culture, out normal);
                Parser.AddCustomConstant("x", (valor + this.h));
                double.TryParse(p.Execute().ToString(), style, culture, out normal2);
                Parser.AddCustomConstant("x", (valor + 3*this.h));
                double.TryParse(p.Execute().ToString(), style, culture, out maisH);
                Parser.AddCustomConstant("x", (valor - 3*this.h));
                double.TryParse(p.Execute().ToString(), style, culture, out menosH);
                valorAtual = (maisH + 3*normal - 3*normal2 - menosH) / (8 * this.h * this.h * this.h);
                if (contador > 1)
                    erro = Math.Abs((valorAnterior - valorAtual) / (Math.Max(1, valorAtual)));
                this.h /= diminui;
            }
            return valorAtual;
        }

    }
}
