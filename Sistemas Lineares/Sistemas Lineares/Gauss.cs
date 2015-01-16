using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistemas_Lineares
{
    class Gauss
    {
        private bool continua = true;
        private double max, aux, pivo, soma;
        private int indMax, tamanho;
        private double[] x;


        public double[] Calcula(double[,] a, double[] b, double n)
        {
            tamanho = Convert.ToInt32(n) - 1;
            x = new Double[tamanho + 1];
            for (int k = 1; k < n; k++)
            {
                max = Math.Abs(a[k, k]);
                for (int i = k; i < n; i++)
                    
                    if (Math.Abs(a[i, k]) >= max)
                    {
                        indMax = i;
                        max = Math.Abs(a[i, k]);
                    }

                    if (max == 0)
                    {
                        continua = false;
                    }
                    else
                    {
                        for (int j = k; j < n; j++)
                        {
                            aux = a[k, j];
                            a[k, j] = a[indMax, j];
                            a[indMax, j] = aux;
                        }
                        aux = b[k];
                        b[k] = b[indMax];
                        b[indMax] = aux;

                    }
                    if (continua)
                    {
                        for (int m = k + 1; m < n; m++)
                        {
                            pivo = a[m, k] / a[k, k];
                            a[m, k] = 0;
                            for (int j = k + 1; j < n; j++)
                            {
                                a[m, j] = a[m, j] - pivo*a[k,j];
                            }
                            b[m] = b[m] - pivo * b[k];
                        }

                    }
                }
                if (a[tamanho, tamanho] == 0)
                {
                    continua = false;
                }

                if (continua)
                {
                    x[tamanho] = b[tamanho] / a[tamanho, tamanho];
                    for (int k = tamanho - 1; k == 1; k--)
                    {
                        soma = 0;
                        for (int j = k + 1; j < tamanho; j++)
                        {
                            soma = soma + a[k, j] * x[j];
                        }
                        x[k] = (b[k] - soma) / a[k, k];
                    
                    }

                }



                return x;


        }       
    }
}