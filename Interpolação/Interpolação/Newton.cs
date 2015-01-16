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
    class Newton
    {
        private double P, termo, h, deltaY;


        public double Calcula(double[,] x, double xbarra, double n)
        {
            h = x[0, 0] - x[1, 0];
            P = P + x[0, 1];
            termo = (xbarra - x[0, 0])/h;
            deltaY = x[1, 1] - x[1, 0];
            P = P + termo * deltaY;
            for (int i = 1; i < (n - 1); i++)
            {
                Console.Write(i);
                termo = termo*(i+1)*(xbarra-x[0,i])/h;
                deltaY = x[1, (i)] - x[1, 0];
                P = P + termo * deltaY;

            }

            return P;
                       
        }


    }
}
