namespace Derivadas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.funcaob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.d3 = new System.Windows.Forms.RadioButton();
            this.d2 = new System.Windows.Forms.RadioButton();
            this.d1 = new System.Windows.Forms.RadioButton();
            this.precisaobox = new System.Windows.Forms.GroupBox();
            this.precisaob = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.xlabel = new System.Windows.Forms.Label();
            this.xb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.respostab = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.x1b = new System.Windows.Forms.Label();
            this.x2b = new System.Windows.Forms.Label();
            this.x2box = new System.Windows.Forms.TextBox();
            this.gradienteb = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.precisaobox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.funcaob);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Função";
            // 
            // funcaob
            // 
            this.funcaob.Location = new System.Drawing.Point(6, 21);
            this.funcaob.Name = "funcaob";
            this.funcaob.Size = new System.Drawing.Size(266, 22);
            this.funcaob.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Derivadas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gradienteb);
            this.groupBox2.Controls.Add(this.d3);
            this.groupBox2.Controls.Add(this.d2);
            this.groupBox2.Controls.Add(this.d1);
            this.groupBox2.Location = new System.Drawing.Point(343, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Derivadas";
            // 
            // d3
            // 
            this.d3.AutoSize = true;
            this.d3.Location = new System.Drawing.Point(3, 72);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(143, 21);
            this.d3.TabIndex = 2;
            this.d3.TabStop = true;
            this.d3.Text = "Derivada Terceira";
            this.d3.UseVisualStyleBackColor = true;
            this.d3.CheckedChanged += new System.EventHandler(this.Form1_Load);
            // 
            // d2
            // 
            this.d2.AutoSize = true;
            this.d2.Location = new System.Drawing.Point(3, 45);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(147, 21);
            this.d2.TabIndex = 1;
            this.d2.TabStop = true;
            this.d2.Text = "Derivada Segunda";
            this.d2.UseVisualStyleBackColor = true;
            this.d2.CheckedChanged += new System.EventHandler(this.Form1_Load);
            // 
            // d1
            // 
            this.d1.AutoSize = true;
            this.d1.Location = new System.Drawing.Point(3, 18);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(142, 21);
            this.d1.TabIndex = 0;
            this.d1.TabStop = true;
            this.d1.Text = "Derivada Primeira";
            this.d1.UseVisualStyleBackColor = true;
            this.d1.CheckedChanged += new System.EventHandler(this.Form1_Load);
            // 
            // precisaobox
            // 
            this.precisaobox.Controls.Add(this.precisaob);
            this.precisaobox.Location = new System.Drawing.Point(12, 124);
            this.precisaobox.Name = "precisaobox";
            this.precisaobox.Size = new System.Drawing.Size(146, 51);
            this.precisaobox.TabIndex = 3;
            this.precisaobox.TabStop = false;
            this.precisaobox.Text = "Precisão";
            // 
            // precisaob
            // 
            this.precisaob.Location = new System.Drawing.Point(6, 21);
            this.precisaob.Name = "precisaob";
            this.precisaob.Size = new System.Drawing.Size(134, 22);
            this.precisaob.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.x2box);
            this.groupBox4.Controls.Add(this.x2b);
            this.groupBox4.Controls.Add(this.x1b);
            this.groupBox4.Controls.Add(this.xlabel);
            this.groupBox4.Controls.Add(this.xb);
            this.groupBox4.Location = new System.Drawing.Point(164, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 106);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valor";
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(6, 24);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(21, 17);
            this.xlabel.TabIndex = 2;
            this.xlabel.Text = "X:";
            // 
            // xb
            // 
            this.xb.Location = new System.Drawing.Point(34, 21);
            this.xb.Name = "xb";
            this.xb.Size = new System.Drawing.Size(118, 22);
            this.xb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resposta:";
            // 
            // respostab
            // 
            this.respostab.Location = new System.Drawing.Point(302, 287);
            this.respostab.Name = "respostab";
            this.respostab.Size = new System.Drawing.Size(155, 22);
            this.respostab.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // x1b
            // 
            this.x1b.AutoSize = true;
            this.x1b.Location = new System.Drawing.Point(6, 24);
            this.x1b.Name = "x1b";
            this.x1b.Size = new System.Drawing.Size(29, 17);
            this.x1b.TabIndex = 3;
            this.x1b.Text = "X1:";
            // 
            // x2b
            // 
            this.x2b.AutoSize = true;
            this.x2b.Location = new System.Drawing.Point(6, 58);
            this.x2b.Name = "x2b";
            this.x2b.Size = new System.Drawing.Size(29, 17);
            this.x2b.TabIndex = 4;
            this.x2b.Text = "X2:";
            // 
            // x2box
            // 
            this.x2box.Location = new System.Drawing.Point(34, 55);
            this.x2box.Name = "x2box";
            this.x2box.Size = new System.Drawing.Size(118, 22);
            this.x2box.TabIndex = 5;
            // 
            // gradienteb
            // 
            this.gradienteb.AutoSize = true;
            this.gradienteb.Location = new System.Drawing.Point(3, 99);
            this.gradienteb.Name = "gradienteb";
            this.gradienteb.Size = new System.Drawing.Size(92, 21);
            this.gradienteb.TabIndex = 3;
            this.gradienteb.TabStop = true;
            this.gradienteb.Text = "Gradiente";
            this.gradienteb.UseVisualStyleBackColor = true;
            this.gradienteb.CheckedChanged += new System.EventHandler(this.Form1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.respostab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.precisaobox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Derivadas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.precisaobox.ResumeLayout(false);
            this.precisaobox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox funcaob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton d2;
        private System.Windows.Forms.RadioButton d1;
        private System.Windows.Forms.GroupBox precisaobox;
        private System.Windows.Forms.TextBox precisaob;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox xb;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox respostab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton d3;
        private System.Windows.Forms.Label x2b;
        private System.Windows.Forms.Label x1b;
        private System.Windows.Forms.TextBox x2box;
        private System.Windows.Forms.RadioButton gradienteb;
    }
}

