namespace WindowsFormsApplication1
{
    partial class Base
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
            this.Titulo = new System.Windows.Forms.Label();
            this.metodosBox = new System.Windows.Forms.GroupBox();
            this.continua = new System.Windows.Forms.RadioButton();
            this.posicaomod = new System.Windows.Forms.RadioButton();
            this.newton = new System.Windows.Forms.RadioButton();
            this.bbisseccao = new System.Windows.Forms.RadioButton();
            this.posicao = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.funcao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xb = new System.Windows.Forms.TextBox();
            this.bx = new System.Windows.Forms.Label();
            this.bb = new System.Windows.Forms.TextBox();
            this.ab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.erroBox = new System.Windows.Forms.GroupBox();
            this.errob = new System.Windows.Forms.TextBox();
            this.respostab = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newtonmod = new System.Windows.Forms.RadioButton();
            this.metodosBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.erroBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(183, 26);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(268, 38);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Zero de funções";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // metodosBox
            // 
            this.metodosBox.Controls.Add(this.newtonmod);
            this.metodosBox.Controls.Add(this.continua);
            this.metodosBox.Controls.Add(this.posicaomod);
            this.metodosBox.Controls.Add(this.newton);
            this.metodosBox.Controls.Add(this.bbisseccao);
            this.metodosBox.Controls.Add(this.posicao);
            this.metodosBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodosBox.Location = new System.Drawing.Point(449, 99);
            this.metodosBox.Name = "metodosBox";
            this.metodosBox.Size = new System.Drawing.Size(181, 197);
            this.metodosBox.TabIndex = 1;
            this.metodosBox.TabStop = false;
            this.metodosBox.Text = "Métodos";
            // 
            // continua
            // 
            this.continua.AutoSize = true;
            this.continua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continua.Location = new System.Drawing.Point(6, 167);
            this.continua.Name = "continua";
            this.continua.Size = new System.Drawing.Size(95, 23);
            this.continua.TabIndex = 7;
            this.continua.TabStop = true;
            this.continua.Text = "Continua";
            this.continua.UseVisualStyleBackColor = true;
            this.continua.CheckedChanged += new System.EventHandler(this.continua_CheckedChanged);
            // 
            // posicaomod
            // 
            this.posicaomod.AutoSize = true;
            this.posicaomod.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posicaomod.Location = new System.Drawing.Point(6, 81);
            this.posicaomod.Name = "posicaomod";
            this.posicaomod.Size = new System.Drawing.Size(174, 23);
            this.posicaomod.TabIndex = 6;
            this.posicaomod.TabStop = true;
            this.posicaomod.Text = "Posição Falsa Mod.";
            this.posicaomod.UseVisualStyleBackColor = true;
            // 
            // newton
            // 
            this.newton.AutoSize = true;
            this.newton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newton.Location = new System.Drawing.Point(6, 110);
            this.newton.Name = "newton";
            this.newton.Size = new System.Drawing.Size(83, 23);
            this.newton.TabIndex = 5;
            this.newton.TabStop = true;
            this.newton.Text = "Newton";
            this.newton.UseVisualStyleBackColor = true;
            // 
            // bbisseccao
            // 
            this.bbisseccao.AutoSize = true;
            this.bbisseccao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbisseccao.Location = new System.Drawing.Point(6, 25);
            this.bbisseccao.Name = "bbisseccao";
            this.bbisseccao.Size = new System.Drawing.Size(106, 23);
            this.bbisseccao.TabIndex = 2;
            this.bbisseccao.TabStop = true;
            this.bbisseccao.Text = "Bissecção";
            this.bbisseccao.UseVisualStyleBackColor = true;
            // 
            // posicao
            // 
            this.posicao.AutoSize = true;
            this.posicao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posicao.Location = new System.Drawing.Point(6, 52);
            this.posicao.Name = "posicao";
            this.posicao.Size = new System.Drawing.Size(133, 23);
            this.posicao.TabIndex = 3;
            this.posicao.TabStop = true;
            this.posicao.Text = "Posição Falsa";
            this.posicao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.funcao);
            this.groupBox1.Location = new System.Drawing.Point(23, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Função";
            // 
            // funcao
            // 
            this.funcao.Location = new System.Drawing.Point(6, 21);
            this.funcao.Name = "funcao";
            this.funcao.Size = new System.Drawing.Size(383, 22);
            this.funcao.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xb);
            this.groupBox2.Controls.Add(this.bx);
            this.groupBox2.Controls.Add(this.bb);
            this.groupBox2.Controls.Add(this.ab);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(23, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 87);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intervalo";
            // 
            // xb
            // 
            this.xb.Location = new System.Drawing.Point(33, 55);
            this.xb.Name = "xb";
            this.xb.Size = new System.Drawing.Size(100, 22);
            this.xb.TabIndex = 6;
            // 
            // bx
            // 
            this.bx.AutoSize = true;
            this.bx.Location = new System.Drawing.Point(6, 60);
            this.bx.Name = "bx";
            this.bx.Size = new System.Drawing.Size(17, 17);
            this.bx.TabIndex = 5;
            this.bx.Text = "X";
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(190, 27);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(100, 22);
            this.bb.TabIndex = 3;
            // 
            // ab
            // 
            this.ab.Location = new System.Drawing.Point(33, 27);
            this.ab.Name = "ab";
            this.ab.Size = new System.Drawing.Size(100, 22);
            this.ab.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "B:";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(190, 284);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(148, 47);
            this.calcular.TabIndex = 3;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // erroBox
            // 
            this.erroBox.Controls.Add(this.errob);
            this.erroBox.Location = new System.Drawing.Point(23, 276);
            this.erroBox.Name = "erroBox";
            this.erroBox.Size = new System.Drawing.Size(161, 55);
            this.erroBox.TabIndex = 4;
            this.erroBox.TabStop = false;
            this.erroBox.Text = "Erro";
            // 
            // errob
            // 
            this.errob.Location = new System.Drawing.Point(6, 21);
            this.errob.Name = "errob";
            this.errob.Size = new System.Drawing.Size(139, 22);
            this.errob.TabIndex = 0;
            // 
            // respostab
            // 
            this.respostab.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respostab.Location = new System.Drawing.Point(190, 366);
            this.respostab.Name = "respostab";
            this.respostab.Size = new System.Drawing.Size(191, 39);
            this.respostab.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(623, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Obs: Eu não lembrava o nome do ultimo método que você ensinou na sala e não tem n" +
    "o material.";
            // 
            // newtonmod
            // 
            this.newtonmod.AutoSize = true;
            this.newtonmod.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtonmod.Location = new System.Drawing.Point(6, 138);
            this.newtonmod.Name = "newtonmod";
            this.newtonmod.Size = new System.Drawing.Size(168, 23);
            this.newtonmod.TabIndex = 8;
            this.newtonmod.TabStop = true;
            this.newtonmod.Text = "Newton Modificado";
            this.newtonmod.UseVisualStyleBackColor = true;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.respostab);
            this.Controls.Add(this.erroBox);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metodosBox);
            this.Controls.Add(this.Titulo);
            this.Name = "Base";
            this.Text = "Zero de Funcoes";
            this.metodosBox.ResumeLayout(false);
            this.metodosBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.erroBox.ResumeLayout(false);
            this.erroBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.GroupBox metodosBox;
        private System.Windows.Forms.RadioButton newton;
        private System.Windows.Forms.RadioButton bbisseccao;
        private System.Windows.Forms.RadioButton posicao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox funcao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox bb;
        private System.Windows.Forms.TextBox ab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.GroupBox erroBox;
        private System.Windows.Forms.TextBox errob;
        private System.Windows.Forms.TextBox respostab;
        private System.Windows.Forms.TextBox xb;
        private System.Windows.Forms.Label bx;
        private System.Windows.Forms.RadioButton posicaomod;
        private System.Windows.Forms.RadioButton continua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton newtonmod;
    }
}

