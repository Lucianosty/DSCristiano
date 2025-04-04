namespace Programa_com_variavel_global
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
            numeros = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btncalcular = new Button();
            btninserir = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // numeros
            // 
            numeros.Location = new Point(48, 86);
            numeros.Name = "numeros";
            numeros.Size = new Size(180, 23);
            numeros.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(48, 60);
            label1.Name = "label1";
            label1.Size = new Size(180, 23);
            label1.TabIndex = 1;
            label1.Text = "Digite o número positivo inteiro";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(48, 181);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 3;
            label2.Text = "O maior número foi:";
            label2.Click += label2_Click;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(296, 420);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btninserir
            // 
            btninserir.Location = new Point(59, 420);
            btninserir.Name = "btninserir";
            btninserir.Size = new Size(75, 23);
            btninserir.TabIndex = 5;
            btninserir.Text = "Inserir";
            btninserir.UseVisualStyleBackColor = true;
            btninserir.Click += btninserir_Click;
            // 
            // label3
            // 
            label3.Location = new Point(48, 219);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 600);
            Controls.Add(label3);
            Controls.Add(btninserir);
            Controls.Add(btncalcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numeros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numeros;
        private Label label1;
        private Label label2;
        private Button btncalcular;
        private Button btninserir;
        private Label label3;
    }
}
