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
    

    public partial class Matriz : Form
    {
        
        private NumberStyles style;
        private CultureInfo culture;
        private Double[,] mat;
        private Double[] x;
        public double indice;




        public Matriz(int ind)
        {
            indice = ind;
            InitializeComponent();
            mat = new Double[ind, ind];
            x = new Double[ind];
            gridView.RowCount = ind;
            gridView.ColumnCount = (ind + 1);
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("en-GB");
            Gauss g = new Gauss();


        
        }

        private void Matriz_Load(object sender, EventArgs e)
        {

        }

        private void confirma_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < indice; i++)
            {
                for (int j = 0; j < indice; j++)
                {
                    Double.TryParse(gridView.Rows[i].Cells[j].Value.ToString(), style, culture, out this.mat[i, j]);

                }

            }
            for (int i = 0; i < indice - 1; i++)
            {
                Double.TryParse(gridView.Rows[Convert.ToInt32(indice) - 1].Cells[i].Value.ToString(), style, culture, out this.x[i]);
            }


            this.Dispose();

        
            
        }

        public Double[,] GetDadosMat()
        {
            return mat;
        }

        public Double[] GetDadosVet()
        {
            return x;
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
