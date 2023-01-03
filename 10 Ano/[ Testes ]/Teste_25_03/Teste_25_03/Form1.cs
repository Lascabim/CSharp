using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Teste_25_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public struct Dados
        {
            public string nome;
            public int quantidade;
            public double preco;
        }

        static Dados[] dados = new Dados[5];
        static int x = 0;
        static int data = 0;
        static double iva_t = 0, iva_f = 0, valor = 0, valortotal = 0;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Pretendes fechar o formulário?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(data > 0)
            {
                textBox5.Text = valortotal.ToString();
            }
            else
            {
                MessageBox.Show("Ainda não foram introduzidos dados na tabela!");
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text != "" &
                textBox2.Text != "" &
                textBox3.Text != "" &
                textBox4.Text != "" & 
                int.Parse(textBox4.Text) < 100 & 
                int.Parse(textBox4.Text) > -1)
            {
                    dados[x].nome = textBox1.Text;
                    dados[x].quantidade = int.Parse(textBox2.Text);
                    dados[x].preco = double.Parse(textBox3.Text);

                    valor = dados[x].preco * dados[x].quantidade;
                    iva_t = double.Parse(textBox4.Text);
                    iva_f = (iva_t * valor) / 100;
                

                    textBox4.ReadOnly = true;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                    valortotal = valortotal + valor;

     
                    MessageBox.Show("Dados Registados");

                    dataGridView1.Rows.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Tens que preencher todos os campos!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(x != 0)
            {

                dataGridView1.Rows.Clear();

                for(int i = 0; i<x; i++)
                {
                    dataGridView1.Rows.Add(dados[x].nome, dados[x].quantidade, dados[x].preco, valor, iva_f);
                }

                data = data + 1;
                MessageBox.Show("Dados Listados");
            }
            else
            {
                MessageBox.Show("Ainda não foram introduzidos dados!");
            }
        }
    }
}