namespace Sistemas_Lineares
{
    partial class Matriz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridView = new System.Windows.Forms.DataGridView();
            this.confirma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 12);
            this.gridView.Name = "gridView";
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(685, 349);
            this.gridView.TabIndex = 0;
            // 
            // confirma
            // 
            this.confirma.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirma.Location = new System.Drawing.Point(262, 367);
            this.confirma.Name = "confirma";
            this.confirma.Size = new System.Drawing.Size(125, 48);
            this.confirma.TabIndex = 1;
            this.confirma.Text = "Confirmar";
            this.confirma.UseVisualStyleBackColor = false;
            this.confirma.Click += new System.EventHandler(this.confirma_Click);
            // 
            // Matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(709, 445);
            this.Controls.Add(this.confirma);
            this.Controls.Add(this.gridView);
            this.Name = "Matriz";
            this.Text = "Matriz";
            this.Load += new System.EventHandler(this.Matriz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button confirma;
    }
}