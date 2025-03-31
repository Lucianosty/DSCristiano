using System.Diagnostics;

namespace calculadora
{
    public partial class Form1 : Form
    {

        float result;
        float n1;
        float n2;

        int operacao;

        public Form1()
        {
            InitializeComponent();
        }
        private void b1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void bmais_Click(object sender, EventArgs e)
        {
            n1 = Int32.Parse(label1.Text);
            label1.Text = "";
            operacao = 1;
        }

        private void bmenos_Click(object sender, EventArgs e)
        {
            n1 = Int32.Parse(label1.Text);
            label1.Text = "";
            operacao = 2;
        }

        private void bdivisao_Click(object sender, EventArgs e)
        {
            n1 = Int32.Parse(label1.Text);
            label1.Text = "";
            operacao = 3;
        }

        private void bmulti_Click(object sender, EventArgs e)
        {
            n1 = Int32.Parse(label1.Text);
            label1.Text = "";
            operacao = 4;
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            n2 = Int32.Parse(label1.Text);
            switch (operacao)
            {

                case 1:

                    result = n1 + n2;

                    break;

                case 2:

                    result = n1 - n2;

                    break;

                case 3:

                    result = n1 / n2;

                    break;

                case 4:

                    result = n1 * n2;

                    break;

            }

            label1.Text = result.ToString();

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
