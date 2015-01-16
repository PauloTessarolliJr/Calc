using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistemas_Lineares
{
    class GaussJacobi
    {
        private double[] x;
        private double max, soma, contador, numerador, denominador, erro;
        private bool CriteriodasLinhas,CriteriodasColunas;

        public double[] Calcula(double[,] a, double[] b, double n)
        {
            erro = 0.01;
            x = new Double[Convert.ToInt32(n)];
            for (int i = 1; i < n; i++)
            {
                soma = 0;
                for (int j = 1; j < n; j++)
                {
                    if (i != j)
                    {
                        soma = soma + Math.Abs(a[i, j]);
                    }
                }
                soma = soma / Math.Abs(a[i, i]);
            }
            if (max < soma)
            {
                max = soma;
            }
            if (max < 1)
            {
                CriteriodasLinhas = true;
            }
            else
            {
                CriteriodasLinhas = false;
            }
                
            max = 0;
            for (int j = 1; j < n; j++)
            {
                soma = 0;
                for (int i = 1; i < n; i++)
                {
                    if (i != j)
                    {
                        soma = soma + Math.Abs(a[i,j]);
                    }
                }
                soma = soma / a[j, j];
                if (max < soma)
                {
                    max = soma;
                }

            }
            if (max < 1)
            {
                CriteriodasColunas = true;
            }
            else
            {
                CriteriodasColunas = false;
            }

            if (CriteriodasLinhas || CriteriodasColunas)
            {
                do
                {
                    contador++;
                    numerador = 0;
                    denominador = 0;
                    for (int i = 1; i < n; i++)
                    {
                        for (int j = 1; j < n; j++)
                        {
                            if (i != j)
                            {
                                x[i] = x[i] + a[i, j] * b[j];
                            }
                        }
                        x[i] = 1 / a[i, i] * b[i];
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
            }



            return x;
        }
    }
}
