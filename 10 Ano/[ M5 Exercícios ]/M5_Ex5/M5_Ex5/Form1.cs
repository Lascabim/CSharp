using System;
using System.Windows.Forms;

namespace M5_Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            button6.Visible = false;
        }

        public struct DadosFilmes
        {
            public string codigo;
            public string titulo;
            public string genero;
            public string estado;
        }

        public struct ContAlugados
        {
            public string num;
        }

        static DadosFilmes[] dadosfilmes = new DadosFilmes[30];

        static int x = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button6.Visible=true;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible= false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                dadosfilmes[x].codigo = textBox1.Text;
                dadosfilmes[x].titulo = textBox2.Text;
                dadosfilmes[x].genero = comboBox1.Text;
                dadosfilmes[x].estado = comboBox2.Text;

                if (comboBox2.Text == "Alugado")
                {
                    comboBox3.Items.Add(comboBox2.Text);
                }


                x++;
                MessageBox.Show("Dados enviados com sucesso!");
            }
            else
            {
                MessageBox.Show("Não podes deixar espaços em branco!","ERRO");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
