using System;
using System.Windows.Forms;

namespace Ficheiros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string box1 = textBox1.Text;
            int caracteres = box1.Length;
            
            textBox2.Text = caracteres.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string box1 = textBox1.Text;
            int ponto = box1.IndexOf(".",0,box1.Length);

            // se encontrar retorna a posição
            // se não encontrar retorna -1

            if (ponto != -1)
            {
                 ponto = ponto + 1;
                 textBox2.Text = ponto.ToString();
            }
            else
            {
                textBox2.Text = "Não há pontos finais!";
            }
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string box1 = textBox1.Text;
            string minuscula = box1.ToLower();

            textBox2.Text = minuscula.ToString();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            string box1 = textBox1.Text;
            string maiuscula = box1.ToUpper();

            textBox2.Text = maiuscula.ToString();

        }
    }
}
