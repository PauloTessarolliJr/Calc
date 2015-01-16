using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistemas_Lineares
{
    class GaussSeidel
    {
        private double numerador, denominador, erro;
        private double[] x;



        public double[] Calcula(double[,] a, double[] b, double n)
        {
            x = new Double[Convert.ToInt32(n)];
            erro = 0.01;
            do
            {
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j < n; j++)
                    {
                        if (i != j)
                        {
                            x[i] = x[i] + a[i, j] * b[i];
                        }
                    }
                    x[i] = 1 / a[i, i] * b[i]; ;
                    if (numerador < Math.Abs(x[i] - b[i]))
                    {
                        numerador = Math.Abs(x[i] - b[i]);
                    }
                    if (denominador < Math.Abs(x[i]))
                    {
                        denominador = Math.Abs(x[i]);
                    }
                }

            } while (numerador / denominador < erro);
            return x;
            
        }

    }
}
