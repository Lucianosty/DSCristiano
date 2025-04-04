namespace Verificador_de_Números_Primos
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
            beprimo = new Button();
            bprimomenor = new Button();
            label1 = new Label();
            txt1 = new TextBox();
            result = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // beprimo
            // 
            beprimo.Location = new Point(22, 232);
            beprimo.Name = "beprimo";
            beprimo.Size = new Size(75, 23);
            beprimo.TabIndex = 0;
            beprimo.Text = "É primo?";
            beprimo.UseVisualStyleBackColor = true;
            beprimo.Click += beprimo_Click;
            // 
            // bprimomenor
            // 
            bprimomenor.Location = new Point(175, 232);
            bprimomenor.Name = "bprimomenor";
            bprimomenor.Size = new Size(105, 23);
            bprimomenor.TabIndex = 1;
            bprimomenor.Text = "Primos menores";
            bprimomenor.UseVisualStyleBackColor = true;
            bprimomenor.Click += bprimomenor_Click;
            // 
            // label1
            // 
            label1.Location = new Point(90, 56);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 2;
            label1.Text = "Digite um número:";
            // 
            // txt1
            // 
            txt1.Location = new Point(90, 93);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 3;
            // 
            // result
            // 
            result.Location = new Point(22, 281);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(174, 281);
            label2.Name = "label2";
            label2.Size = new Size(106, 191);
            label2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 564);
            Controls.Add(label2);
            Controls.Add(result);
            Controls.Add(txt1);
            Controls.Add(label1);
            Controls.Add(bprimomenor);
            Controls.Add(beprimo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button beprimo;
        private Button bprimomenor;
        private Label label1;
        private TextBox txt1;
        private Label result;
        private Label label2;
    }
}
