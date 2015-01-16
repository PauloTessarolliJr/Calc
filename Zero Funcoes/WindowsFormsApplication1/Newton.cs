using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAMP;

namespace WindowsFormsApplication1
{
    class Newton
    {
        private NumberStyles style;
        private CultureInfo culture;
        private Parser p;
        private string func;
        private double x1, erro, x,e;
        private bool testeEntrada = true;
        private double fx;
        private Value v;


        public Newton(string func, string x, string erro)
        {
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("en-GB");
            this.func = func;
            if (!double.TryParse(x, style, culture, out this.x))
                testeEntrada = false;    
            if (!double.TryParse(erro, style, culture, out this.erro))
                testeEntrada = false;
            if (!testeEntrada)
                System.Windows.Forms.MessageBox.Show("Entrada Invalida");

            if (string.IsNullOrEmpty(func))
            {
                System.Windows.Forms.MessageBox.Show("Entrada Invalida");
                testeEntrada = false;
            }
        }

        private bool tryParse()
        {
            try
            {
                p = Parser.Parse(this.func);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string Calcula()
        {
            if (testeEntrada)
            {
                if (!this.tryParse())
                {
                    System.Windows.Forms.MessageBox.Show("Incompatível");
                    return null;
                }
                Parser.AddCustomConstant("x", x);
                v = p.Execute();
                double.TryParse(v.ToString(), style, culture, out fx);

                do
                {
                    Derivada d = new Derivada(func);
                    x1 = x - fx / d.Calcula(x);
                    e = Math.Abs((x1 - x) / (Math.Max(1, x1)));
                    x = x1;
                } while (erro > e); 
                return x.ToString();
            }
            return null;
        }
    }
}