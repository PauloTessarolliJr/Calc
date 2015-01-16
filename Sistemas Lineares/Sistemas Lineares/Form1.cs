using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistemas_Lineares
{
    public partial class Form1 : Form
    {
        
        private NumberStyles style;
        private CultureInfo culture;
        private int pontos;
        private Matriz matriz ;
        private double[] vet, r;
        private double[,] mat;
        Gauss g = new Gauss();
        GaussSeidel gs = new GaussSeidel();
        GaussJacobi gj = new GaussJacobi();



        public Form1()
        {

            InitializeComponent();
            vetGrid.RowCount = 1;          
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("en-GB");
            if (int.TryParse(matInd.Text, style, culture, out this.pontos))
            {
                matriz = new Matriz(pontos);
                matriz.Show();
            }

            else

                System.Windows.Forms.MessageBox.Show("Insira um valor válido");

        }

        private void calcb_Click(object sender, EventArgs e)
        {
            if (gaussb.Checked)
            {
                vet = new Double[pontos];
                this.mat = matriz.GetDadosMat();
                this.vet = matriz.GetDadosVet();
                this.r = g.Calcula(mat, vet, pontos);
                vetGrid.RowCount = pontos;
                for (int i = 0; i < pontos; i++)
                {
                    Console.Write(r[i]);
                    vetGrid.Rows[i].Cells[0].Value = r[i].ToString();
                }
            }

            if (gseidelb.Checked)
            {
                vet = new Double[pontos];
                this.mat = matriz.GetDadosMat();
                this.vet = matriz.GetDadosVet();
                this.r = gs.Calcula(mat, vet, pontos);
                vetGrid.RowCount = pontos;
                for (int i = 0; i < pontos; i++)
                {
                    Console.Write(r[i]);
                    vetGrid.Rows[i].Cells[0].Value = r[i].ToString();
                }
            }

            if (jacobib.Checked)
            {
                vet = new Double[pontos];
                this.mat = matriz.GetDadosMat();
                this.vet = matriz.GetDadosVet();
                this.r = gj.Calcula(mat, vet, pontos);
                vetGrid.RowCount = pontos;
                for (int i = 0; i < pontos; i++)
                {
                    Console.Write(r[i]);
                    vetGrid.Rows[i].Cells[0].Value = r[i].ToString();
                }
            }
        }

        
        
        
        
        
        
        
        
        
        private void vetGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vetGrid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }









    
    }
}
