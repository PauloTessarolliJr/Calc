namespace Interpolação
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
            this.btnok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pontosb = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blagrange = new System.Windows.Forms.RadioButton();
            this.newtonb = new System.Windows.Forms.RadioButton();
            this.xbarrab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultadob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de pontos:";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(277, 5);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pontosb
            // 
            this.pontosb.Location = new System.Drawing.Point(171, 6);
            this.pontosb.Name = "pontosb";
            this.pontosb.Size = new System.Drawing.Size(100, 22);
            this.pontosb.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.fx});
            this.grid.Location = new System.Drawing.Point(12, 34);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(138, 316);
            this.grid.TabIndex = 4;
            // 
            // x
            // 
            this.x.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.x.HeaderText = "x";
            this.x.Name = "x";
            this.x.Width = 39;
            // 
            // fx
            // 
            this.fx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fx.HeaderText = "f(x)";
            this.fx.Name = "fx";
            this.fx.Width = 53;
            // 
            // blagrange
            // 
            this.blagrange.AutoSize = true;
            this.blagrange.Location = new System.Drawing.Point(347, 54);
            this.blagrange.Name = "blagrange";
            this.blagrange.Size = new System.Drawing.Size(90, 21);
            this.blagrange.TabIndex = 5;
            this.blagrange.TabStop = true;
            this.blagrange.Text = "Lagrange";
            this.blagrange.UseVisualStyleBackColor = true;
            // 
            // newtonb
            // 
            this.newtonb.AutoSize = true;
            this.newtonb.Location = new System.Drawing.Point(347, 81);
            this.newtonb.Name = "newtonb";
            this.newtonb.Size = new System.Drawing.Size(76, 21);
            this.newtonb.TabIndex = 6;
            this.newtonb.TabStop = true;
            this.newtonb.Text = "Newton";
            this.newtonb.UseVisualStyleBackColor = true;
            // 
            // xbarrab
            // 
            this.xbarrab.Location = new System.Drawing.Point(214, 31);
            this.xbarrab.Name = "xbarrab";
            this.xbarrab.Size = new System.Drawing.Size(44, 22);
            this.xbarrab.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "xbarra:";
            // 
            // resultadob
            // 
            this.resultadob.Location = new System.Drawing.Point(347, 377);
            this.resultadob.Name = "resultadob";
            this.resultadob.Size = new System.Drawing.Size(100, 22);
            this.resultadob.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultadob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xbarrab);
            this.Controls.Add(this.newtonb);
            this.Controls.Add(this.blagrange);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.pontosb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Interpolação";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pontosb;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn fx;
        private System.Windows.Forms.RadioButton blagrange;
        private System.Windows.Forms.RadioButton newtonb;
        private System.Windows.Forms.TextBox xbarrab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultadob;
        private System.Windows.Forms.Label label3;
    }
}

