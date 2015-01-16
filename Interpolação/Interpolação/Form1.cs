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
    public partial class Form1 : Form
    {
        private NumberStyles style;
        private CultureInfo culture;
        private double[,] dados;
        private double xbarra, valor;
        Lagrange l = new Lagrange(); 
        Newton n = new Newton();
        private int pontos;
        private bool erro = true;

        public Form1()
        {
            InitializeComponent();
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("en-GB");
            erro = false;

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("en-GB");
            if (int.TryParse(pontosb.Text, style, culture, out this.pontos))
            {
                if (pontos >= 2)
                {
                    grid.RowCount = pontos;
                }
                else
                    System.Windows.Forms.MessageBox.Show("São necessários mais de dois pontos");
            }
            else
                System.Windows.Forms.MessageBox.Show("Insira um valor válido");
            dados = new double[pontos, 2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (blagrange.Checked)
            {
                for (int i = 0; i < pontos; i++)
                {

                    double.TryParse(grid.Rows[i].Cells[0].Value.ToString(), style, culture, out this.dados[i, 0]);
                    double.TryParse(grid.Rows[i].Cells[1].Value.ToString(), style, culture, out this.dados[i, 1]);
                }
                xbarra = Convert.ToDouble(xbarrab.Text);

                valor = l.Calcula(dados, xbarra, pontos);
                resultadob.Text = valor.ToString();                              
            }
            if (newtonb.Checked)
            {
                for (int i = 0; i < pontos; i++)
                {

                    double.TryParse(grid.Rows[i].Cells[0].Value.ToString(), style, culture, out this.dados[i, 0]);
                    double.TryParse(grid.Rows[i].Cells[1].Value.ToString(), style, culture, out this.dados[i, 1]);
                }
                xbarra = Convert.ToDouble(xbarrab.Text);

                valor = n.Calcula(dados, xbarra, pontos);
                resultadob.Text = valor.ToString();
            }
        }
        public double[,] GetDados()
        {
            return dados;
        }

        public bool checaErro()
        {
            return erro;
        }


    }
}
