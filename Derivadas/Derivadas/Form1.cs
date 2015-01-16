using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Derivadas
{

    

    public partial class Form1 : Form
    {

        double xvalor,recebe;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (d1.Checked)
            {
                xvalor = Double.Parse(xb.Text);
                Derivada d = new Derivada(funcaob.Text);
                recebe = d.Calcula(xvalor);
                respostab.Text = recebe.ToString();
            }
            if (d2.Checked)
            {
                xvalor = Double.Parse(xb.Text);
                DerivadaSegunda s = new DerivadaSegunda(funcaob.Text);
                recebe = s.Calcula(xvalor);
                respostab.Text = recebe.ToString();
            }
            if (d3.Checked)
            {
                xvalor = Double.Parse(xb.Text);
                DerivadaSegunda s = new DerivadaSegunda(funcaob.Text);
                recebe = s.Calcula(xvalor);
                respostab.Text = recebe.ToString();
            }
            if (gradienteb.Checked)
            {
                respostab.Text = "Não Implementado.";
            }


        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (d1.Checked)
            {
                xlabel.Visible = true;
                x2b.Visible = false;
                x1b.Visible = false;
                x2box.Visible = false;

            }
            if (d2.Checked)
            {
                xlabel.Visible = true;
                x2b.Visible = false;
                x1b.Visible = false;
                x2box.Visible = false;
            }
            if (d3.Checked)
            {
                xlabel.Visible = true;
                x2b.Visible = false;
                x1b.Visible = false;
                x2box.Visible = false;
            }
            if (gradienteb.Checked)
            {
                xlabel.Visible = false;
                x2b.Visible = true;
                x1b.Visible = true;
                x2box.Visible = true;
            }

        }
    }
}
