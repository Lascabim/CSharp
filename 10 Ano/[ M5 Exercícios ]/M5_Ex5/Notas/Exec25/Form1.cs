using System;
using System.Windows.Forms;

namespace Exec25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        static string resultado;

        private void button1_Click(object sender, EventArgs e)
        {
            //  ><
          
            int num;

            num = int.Parse(box.Text);

            if (num > 20 || num < 0)
            {
                MessageBox.Show("Introduz uma nota válida, entre 0 e 20!","ERRO");
            }
            else if (num <= 5 && num > -1)
            {
                resultado = "Fraco";
            }
            else if (num <= 9 && num > 5)
            {
                resultado = "Insuficiente";
            }
            else if (num <= 14 && num > 9)
            {
                resultado = "Suficiente";
            }
            else if (num <= 18 && num > 14)
            {
                resultado = "Bom";
            }
            else if (num == 19 || num == 20)
            {
                resultado = "Muito Bom";
            }

            visor.Text = resultado;

        }
    }
}
