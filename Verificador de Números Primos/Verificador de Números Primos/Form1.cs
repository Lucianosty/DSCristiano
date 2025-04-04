namespace Verificador_de_Números_Primos
{
    public partial class Form1 : Form
    {

        int numeropri;
        int i = 1;
        int contador;
        int contador2;

        public Form1()
        {
            InitializeComponent();
        }

        private void beprimo_Click(object sender, EventArgs e)
        {
            numeropri = Int32.Parse(txt1.Text);
            while (i <= numeropri)
            {
                if (numeropri % i == 0)
                {
                    contador++;
                }
                i++;
            }
            if (contador == 2)
            {
                result.Text = "É primo";
                contador = 0;
                i = 1;
            }
            else
            {
                result.Text = "Não é primo";
                i = 1;
                contador = 0;
            }
        }

        private void bprimomenor_Click(object sender, EventArgs e)
        {
            numeropri = Int32.Parse(txt1.Text);
            for (int x = 1; x < numeropri; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                    {
                        contador2++;
                    }

                }
                if (contador2 == 2)
                {
                    label2.Text = label2.Text + x.ToString() + " ";

                    contador2 = 0;

                }
                else
                {
                    contador2 = 0;
                }
            }
        }

    }
}
