namespace Sistemas_Lineares
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.matInd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gaussb = new System.Windows.Forms.RadioButton();
            this.calcb = new System.Windows.Forms.Button();
            this.vetGrid = new System.Windows.Forms.DataGridView();
            this.gseidelb = new System.Windows.Forms.RadioButton();
            this.jacobib = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.vetGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordem Matriz:";
            // 
            // matInd
            // 
            this.matInd.Location = new System.Drawing.Point(115, 6);
            this.matInd.Name = "matInd";
            this.matInd.Size = new System.Drawing.Size(100, 22);
            this.matInd.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gaussb
            // 
            this.gaussb.AutoSize = true;
            this.gaussb.Location = new System.Drawing.Point(306, 7);
            this.gaussb.Name = "gaussb";
            this.gaussb.Size = new System.Drawing.Size(168, 21);
            this.gaussb.TabIndex = 3;
            this.gaussb.TabStop = true;
            this.gaussb.Text = "Metodo Gauss Parcial";
            this.gaussb.UseVisualStyleBackColor = true;
            // 
            // calcb
            // 
            this.calcb.Location = new System.Drawing.Point(84, 77);
            this.calcb.Name = "calcb";
            this.calcb.Size = new System.Drawing.Size(131, 53);
            this.calcb.TabIndex = 4;
            this.calcb.Text = "Calcular";
            this.calcb.UseVisualStyleBackColor = true;
            this.calcb.Click += new System.EventHandler(this.calcb_Click);
            // 
            // vetGrid
            // 
            this.vetGrid.AllowUserToAddRows = false;
            this.vetGrid.AllowUserToDeleteRows = false;
            this.vetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vetGrid.Location = new System.Drawing.Point(49, 136);
            this.vetGrid.Name = "vetGrid";
            this.vetGrid.RowTemplate.Height = 24;
            this.vetGrid.Size = new System.Drawing.Size(166, 164);
            this.vetGrid.TabIndex = 5;
            this.vetGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vetGrid_CellContentClick);
            this.vetGrid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.vetGrid_UserAddedRow);
            // 
            // gseidelb
            // 
            this.gseidelb.AutoSize = true;
            this.gseidelb.Location = new System.Drawing.Point(306, 34);
            this.gseidelb.Name = "gseidelb";
            this.gseidelb.Size = new System.Drawing.Size(164, 21);
            this.gseidelb.TabIndex = 6;
            this.gseidelb.TabStop = true;
            this.gseidelb.Text = "Metodo Gauss Seidel";
            this.gseidelb.UseVisualStyleBackColor = true;
            // 
            // jacobib
            // 
            this.jacobib.AutoSize = true;
            this.jacobib.Location = new System.Drawing.Point(306, 61);
            this.jacobib.Name = "jacobib";
            this.jacobib.Size = new System.Drawing.Size(121, 21);
            this.jacobib.TabIndex = 7;
            this.jacobib.TabStop = true;
            this.jacobib.Text = "Metodo Jacobi";
            this.jacobib.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 304);
            this.Controls.Add(this.jacobib);
            this.Controls.Add(this.gseidelb);
            this.Controls.Add(this.vetGrid);
            this.Controls.Add(this.calcb);
            this.Controls.Add(this.gaussb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matInd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vetGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox matInd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton gaussb;
        private System.Windows.Forms.Button calcb;
        private System.Windows.Forms.DataGridView vetGrid;
        private System.Windows.Forms.RadioButton gseidelb;
        private System.Windows.Forms.RadioButton jacobib;





    }
}

