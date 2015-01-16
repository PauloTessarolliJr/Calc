using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integração
{
    public partial class Form1 : Form
    {

        private double avalor, bvalor, recebe;


        public Form1()
        {
            InitializeComponent();
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (rb.Checked)
            {
                avalor = Double.Parse(ab.Text);
                bvalor = Double.Parse(bb.Text);
                retangulo r = new retangulo(funcaob.Text);
                recebe = r.Calcula(avalor, bvalor);
                respostab.Text = recebe.ToString();

            }
            if (tb.Checked)
            {
                avalor = Double.Parse(ab.Text);
                bvalor = Double.Parse(bb.Text);
                trapezio t = new trapezio(funcaob.Text);
                recebe = t.Calcula(avalor, bvalor);
                respostab.Text = recebe.ToString();

            }
            if (utb.Checked)
            {
                avalor = Double.Parse(ab.Text);
                bvalor = Double.Parse(bb.Text);
                terçosimpson t = new terçosimpson(funcaob.Text);
                recebe = t.Calcula(avalor, bvalor);
                respostab.Text = recebe.ToString();


            }
            if (tob.Checked)
            {
                avalor = Double.Parse(ab.Text);
                bvalor = Double.Parse(bb.Text);
                tresoitavossimpson t = new tresoitavossimpson(funcaob.Text);
                recebe = t.Calcula(avalor, bvalor);
                respostab.Text = recebe.ToString();


            }

        }
    }
}
