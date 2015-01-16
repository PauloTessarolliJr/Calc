using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAMP;

namespace WindowsFormsApplication1
{
    class Bisseccao
    {
        private NumberStyles style;
        private CultureInfo culture;
        private Parser p;
        private string func;
        private double a, b, erro, x;
        private bool testeEntrada = true;
        private int iteracoes = 0;
        private double fa, fb, fx;
        private Value v;

        public Bisseccao(string func, string a, string b, string erro)
        {
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("en-GB");
            this.func = func;
            if (!double.TryParse(a, style, culture, out this.a))
                testeEntrada = false;
            if (!double.TryParse(b, style, culture, out this.b))
                testeEntrada = false;
            if (!double.TryParse(erro, style, culture, out this.erro))
                testeEntrada = false;
            if (!testeEntrada)
                System.Windows.Forms.MessageBox.Show("Entrada Invalida");
            if (this.b <= this.a)
            {
                System.Windows.Forms.MessageBox.Show("Intervalo Invalido");
                testeEntrada = false;
            }
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
                Parser.AddCustomConstant("x", a);
                v = p.Execute();
                double.TryParse(v.ToString(), style, culture, out fa);
                Parser.AddCustomConstant("x", b);
                v = p.Execute();
                double.TryParse(v.ToString(), style, culture, out fb);
                if ((fa * fb) > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Sem raiz.");
                    return null;
                }
                do
                {
                    x = (a + b) / 2;
                    Parser.AddCustomConstant("x", a);
                    v = p.Execute();
                    double.TryParse(v.ToString(), style, culture, out fa);
                    Parser.AddCustomConstant("x", b);
                    v = p.Execute();
                    double.TryParse(v.ToString(), style, culture, out fb);
                    Parser.AddCustomConstant("x", x);
                    v = p.Execute();
                    double.TryParse(v.ToString(), style, culture, out fx);
                    if (fa * fx > 0)
                        a = x;
                    else
                        b = x;
                    iteracoes++;
                } while (Math.Abs(fx) > erro);
                return x.ToString();
            }
            return null;
        }
    }
}
