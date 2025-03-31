namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            b7 = new Button();
            b4 = new Button();
            b1 = new Button();
            b8 = new Button();
            b5 = new Button();
            b2 = new Button();
            b9 = new Button();
            b6 = new Button();
            b3 = new Button();
            b0 = new Button();
            bmais = new Button();
            bmenos = new Button();
            bdivisao = new Button();
            bmulti = new Button();
            bigual = new Button();
            limpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(65, 42);
            label1.Name = "label1";
            label1.Size = new Size(271, 71);
            label1.TabIndex = 0;
            // 
            // b7
            // 
            b7.Location = new Point(41, 148);
            b7.Name = "b7";
            b7.Size = new Size(59, 41);
            b7.TabIndex = 1;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b4
            // 
            b4.Location = new Point(41, 204);
            b4.Name = "b4";
            b4.Size = new Size(59, 39);
            b4.TabIndex = 2;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b1
            // 
            b1.Location = new Point(41, 263);
            b1.Name = "b1";
            b1.Size = new Size(59, 37);
            b1.TabIndex = 3;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b8
            // 
            b8.Location = new Point(127, 148);
            b8.Name = "b8";
            b8.Size = new Size(59, 41);
            b8.TabIndex = 4;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b5
            // 
            b5.Location = new Point(127, 204);
            b5.Name = "b5";
            b5.Size = new Size(59, 39);
            b5.TabIndex = 5;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b2
            // 
            b2.Location = new Point(127, 263);
            b2.Name = "b2";
            b2.Size = new Size(59, 37);
            b2.TabIndex = 6;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b9
            // 
            b9.Location = new Point(211, 148);
            b9.Name = "b9";
            b9.Size = new Size(60, 41);
            b9.TabIndex = 7;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b6
            // 
            b6.Location = new Point(211, 204);
            b6.Name = "b6";
            b6.Size = new Size(60, 39);
            b6.TabIndex = 8;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b3
            // 
            b3.Location = new Point(211, 263);
            b3.Name = "b3";
            b3.Size = new Size(60, 37);
            b3.TabIndex = 9;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b0
            // 
            b0.Location = new Point(211, 316);
            b0.Name = "b0";
            b0.Size = new Size(60, 37);
            b0.TabIndex = 10;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // bmais
            // 
            bmais.Location = new Point(337, 148);
            bmais.Name = "bmais";
            bmais.Size = new Size(54, 41);
            bmais.TabIndex = 11;
            bmais.Text = "+";
            bmais.UseVisualStyleBackColor = true;
            bmais.Click += bmais_Click;
            // 
            // bmenos
            // 
            bmenos.Location = new Point(337, 204);
            bmenos.Name = "bmenos";
            bmenos.Size = new Size(54, 36);
            bmenos.TabIndex = 12;
            bmenos.Text = "-";
            bmenos.UseVisualStyleBackColor = true;
            bmenos.Click += bmenos_Click;
            // 
            // bdivisao
            // 
            bdivisao.Location = new Point(337, 263);
            bdivisao.Name = "bdivisao";
            bdivisao.Size = new Size(54, 37);
            bdivisao.TabIndex = 13;
            bdivisao.Text = "/";
            bdivisao.UseVisualStyleBackColor = true;
            bdivisao.Click += bdivisao_Click;
            // 
            // bmulti
            // 
            bmulti.Location = new Point(337, 316);
            bmulti.Name = "bmulti";
            bmulti.Size = new Size(54, 37);
            bmulti.TabIndex = 14;
            bmulti.Text = "*";
            bmulti.UseVisualStyleBackColor = true;
            bmulti.Click += bmulti_Click;
            // 
            // bigual
            // 
            bigual.Location = new Point(337, 371);
            bigual.Name = "bigual";
            bigual.Size = new Size(54, 37);
            bigual.TabIndex = 15;
            bigual.Text = "=";
            bigual.UseVisualStyleBackColor = true;
            bigual.Click += bigual_Click;
            // 
            // limpar
            // 
            limpar.Location = new Point(41, 316);
            limpar.Name = "limpar";
            limpar.Size = new Size(59, 37);
            limpar.TabIndex = 16;
            limpar.Text = "C";
            limpar.UseVisualStyleBackColor = true;
            limpar.Click += limpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 423);
            Controls.Add(limpar);
            Controls.Add(bigual);
            Controls.Add(bmulti);
            Controls.Add(bdivisao);
            Controls.Add(bmenos);
            Controls.Add(bmais);
            Controls.Add(b0);
            Controls.Add(b3);
            Controls.Add(b6);
            Controls.Add(b9);
            Controls.Add(b2);
            Controls.Add(b5);
            Controls.Add(b8);
            Controls.Add(b1);
            Controls.Add(b4);
            Controls.Add(b7);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button b7;
        private Button b4;
        private Button b1;
        private Button b8;
        private Button b5;
        private Button b2;
        private Button b9;
        private Button b6;
        private Button b3;
        private Button b0;
        private Button bmais;
        private Button bmenos;
        private Button bdivisao;
        private Button bmulti;
        private Button bigual;
        private Button limpar;
    }
}
