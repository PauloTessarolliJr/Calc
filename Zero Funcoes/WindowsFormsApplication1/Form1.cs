using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            if (bbisseccao.Checked)
            {
                Bisseccao b = new Bisseccao(funcao.Text, ab.Text, bb.Text, errob.Text);
                respostab.Text=b.Calcula();

            }

            if (posicao.Checked)
            {
                Posicao p = new Posicao(funcao.Text, ab.Text, bb.Text, errob.Text);
                respostab.Text = p.Calcula();
            }

            if (newton.Checked)
            {
                Newton n = new Newton(funcao.Text, xb.Text, errob.Text);
                respostab.Text = n.Calcula();
            }
            if (posicaomod.Checked)
            {
                PosMod p = new PosMod(funcao.Text, ab.Text, bb.Text, errob.Text);
                respostab.Text = p.Calcula();

            }
            if (continua.Checked)
            {
                continua c = new continua(funcao.Text, ab.Text, bb.Text, errob.Text);
                respostab.Text = c.Calcula();

            }
            if (newtonmod.Checked)
            {
                NewtonMod n = new NewtonMod(funcao.Text, xb.Text, errob.Text);
                respostab.Text = n.Calcula();
            }

                
        }

        private void continua_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
