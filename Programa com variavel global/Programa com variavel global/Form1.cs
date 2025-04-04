namespace Programa_com_variavel_global
{
    public partial class Form1 : Form
    {

        int num;
        int nummaior;

        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            label3.Text = nummaior.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(numeros.Text);
            numeros.Text = "";
            while (num > nummaior)
            {
                nummaior = num;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
