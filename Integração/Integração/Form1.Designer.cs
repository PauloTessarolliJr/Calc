namespace Integração
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.utb = new System.Windows.Forms.RadioButton();
            this.tb = new System.Windows.Forms.RadioButton();
            this.rb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.respostab = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.Label();
            this.bb = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.ab = new System.Windows.Forms.TextBox();
            this.tob = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.funcaob);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Função";
            // 
            // funcaob
            // 
            this.funcaob.Location = new System.Drawing.Point(6, 21);
            this.funcaob.Name = "funcaob";
            this.funcaob.Size = new System.Drawing.Size(248, 22);
            this.funcaob.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tob);
            this.groupBox2.Controls.Add(this.utb);
            this.groupBox2.Controls.Add(this.tb);
            this.groupBox2.Controls.Add(this.rb);
            this.groupBox2.Location = new System.Drawing.Point(373, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 127);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Métodos";
            // 
            // utb
            // 
            this.utb.AutoSize = true;
            this.utb.Location = new System.Drawing.Point(6, 75);
            this.utb.Name = "utb";
            this.utb.Size = new System.Drawing.Size(107, 21);
            this.utb.TabIndex = 3;
            this.utb.TabStop = true;
            this.utb.Text = "1/3 Simpson";
            this.utb.UseVisualStyleBackColor = true;
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Location = new System.Drawing.Point(6, 48);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(85, 21);
            this.tb.TabIndex = 2;
            this.tb.TabStop = true;
            this.tb.Text = "Trapézio";
            this.tb.UseVisualStyleBackColor = true;
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.Location = new System.Drawing.Point(6, 21);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(101, 21);
            this.rb.TabIndex = 1;
            this.rb.TabStop = true;
            this.rb.Text = "Retangulos";
            this.rb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Integração";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado:";
            // 
            // respostab
            // 
            this.respostab.Location = new System.Drawing.Point(266, 205);
            this.respostab.Name = "respostab";
            this.respostab.Size = new System.Drawing.Size(201, 22);
            this.respostab.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb);
            this.groupBox3.Controls.Add(this.bb);
            this.groupBox3.Controls.Add(this.la);
            this.groupBox3.Controls.Add(this.ab);
            this.groupBox3.Location = new System.Drawing.Point(12, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 52);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valores";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(114, 29);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(20, 17);
            this.lb.TabIndex = 9;
            this.lb.Text = "b:";
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(140, 26);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(76, 22);
            this.bb.TabIndex = 8;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(6, 29);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(20, 17);
            this.la.TabIndex = 7;
            this.la.Text = "a:";
            // 
            // ab
            // 
            this.ab.Location = new System.Drawing.Point(32, 26);
            this.ab.Name = "ab";
            this.ab.Size = new System.Drawing.Size(76, 22);
            this.ab.TabIndex = 6;
            // 
            // tob
            // 
            this.tob.AutoSize = true;
            this.tob.Location = new System.Drawing.Point(6, 102);
            this.tob.Name = "tob";
            this.tob.Size = new System.Drawing.Size(107, 21);
            this.tob.TabIndex = 4;
            this.tob.TabStop = true;
            this.tob.Text = "3/8 Simpson";
            this.tob.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 255);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.respostab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Integração";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox funcaob;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton tb;
        private System.Windows.Forms.RadioButton rb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox respostab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox bb;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox ab;
        private System.Windows.Forms.RadioButton utb;
        private System.Windows.Forms.RadioButton tob;
    }
}

