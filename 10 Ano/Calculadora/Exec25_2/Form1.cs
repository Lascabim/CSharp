using System;
using System.Media;
using System.Windows.Forms;

namespace Exec25_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double num1 = 0, num2 = 0, resultado;
        static string op;
        

        private void botao1_Click(object sender, EventArgs e)
        {
            visor.Text += "1";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            visor.Text += "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            visor.Text += "3";
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            visor.Text += "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            visor.Text += "5";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            visor.Text += "6";
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            visor.Text += "7";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            visor.Text += "8";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            visor.Text += "9";
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            visor.Text += "0";
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            visor.Text += ",";
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            visor.Text = "";
        }

        private void vezes_Click(object sender, EventArgs e)
        {
            if(visor.Text == "")
            {
                visor.Text = "0";
            }

            num1 = double.Parse(visor.Text);
            visor.Clear();
            op = "*";
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            if (visor.Text == "")
            {
                visor.Text = "0";
            }

            num1 = double.Parse(visor.Text);
            visor.Clear();
            op = "/";
        }

        private void mais_Click(object sender, EventArgs e)
        {

            if (visor.Text == "")
            {
                visor.Text = "0";
            }

            num1 = double.Parse(visor.Text);
            visor.Clear();

            op = "+";
        }

        private void menos_Click(object sender, EventArgs e)
        {
            if (visor.Text == "")
            {
                visor.Text = "0";
            }

            num1 = double.Parse(visor.Text);
            visor.Clear();
            op = "-";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(visor.Text);
            visor.Clear();

            if (op == "*")
            {
                resultado = num1 * num2;
            }
            else if (op == "/")
            {
                resultado = num1 / num2;
            }
            else if (op == "+")
            {
                resultado = num1 + num2;
            }
            else if (op == "-")
            {
                resultado = num1 - num2;
            }


            visor.Text = resultado.ToString();

            num1 = 0;
            num2 = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sSound = new SoundPlayer(@"C:\Users\Bandeira\Downloads\never.wav");
            sSound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sSound = new SoundPlayer(@"C:\Users\Bandeira\Downloads\stop.wav");
            sSound.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void visor_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
