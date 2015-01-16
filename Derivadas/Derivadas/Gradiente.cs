using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Derivadas
{
    //Não consegui implementar a tempo.
    class Gradiente
    {
        private double[] x;
        private double h, erro, d1, d2, f1, f2, xi;

        public double[] Calcula()
        {
            return x;

        }


        private double DerivadaParcial(string func, double[] x, double NumeroVariaveis, int i)
        {
            h = 1;
            erro = 0.001;
            d1 = 0;
            xi = x[i];
            do
            {
                x[i] = xi + h;
                for (int j = 1; j < NumeroVariaveis; j++)
                {

                }
            } while (Math.Abs(d2 - d1) < erro);
            return i;
        }

        
    }
}
