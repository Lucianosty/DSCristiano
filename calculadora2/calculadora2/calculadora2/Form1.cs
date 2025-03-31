namespace calculadora2
{
    public partial class Form1 : Form
    {



        float result;
        float n1;
        float n2;

        int operacao;

        string text;

        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
            text = text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
            text = text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
            text = text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
            text = text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
            text = text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
            text = text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
            text = text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
            text = text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
            text = text + "9";
        }

        private void bmais_Click(object sender, EventArgs e)
        {
            n1 = Int32.Parse(label1.Text);
            label1.Text = "";
            operacao = 1;
            text = text + "+";
        }

        private void bmenos_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(label1.Text);
            label1.Text = "";
            operacao = 2;
            text = text + "-";
        }

        private void bdivisao_Click(object sender, EventArgs e)
        {
            n1 = Int32.Parse(label1.Text);
            label1.Text = "";
            operacao = 3;
            text = text + "/";
        }

        private void bmulti_Click(object sender, EventArgs e)
        {
            n1 += Int32.Parse(label1.Text);
            label1.Text = "";
            operacao = 4;
            text = text + "*";
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

            text = text + "=";

            label2.Text = label2.Text + text + result;

            text = "";
            

        }


        private void b0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
            text = text + "0";
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
