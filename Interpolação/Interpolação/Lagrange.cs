using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interpolação
{
    class Lagrange
    {
        private double Pn, P;


        public double Calcula(double[,] vet, double xbarra, double n)
        {
            Pn = 0;
            n = 2;
            for (int j = 0; j < n; j++)
            {
                P = 1;
                for (int i = 0; i < n; i++)
                {
                    if (i != j)
                    {
                        P = P * ((xbarra - vet[i,0]) / (vet[j,0] - vet[i,0]));
                        Pn = P * vet[j,1] + Pn;
                    }
                }
            }
            return Pn;
        }

    }
}
