using System;
using System.IO;
using System.Windows.Forms;

namespace FichaFicheiros
{
    public partial class Form1 : Form
    {
        static int codigo;
        static string descricao;
        static string categoria;
        static int preco;

        bool flag = false;

        static string caminho = Application.StartupPath + "/ficheiro1.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(caminho) == false)
            {
                FileStream registo = new FileStream(caminho, FileMode.CreateNew, FileAccess.Write);
            }
        }

        // PROCEDIMENTOS


        private void Atualizar()
        {
            if (File.Exists(caminho))
            {
                FileStream registoo = new FileStream(caminho, FileMode.Open, FileAccess.Read);
                BinaryReader BRR = new BinaryReader(registoo);

                dataGridView1.Rows.Clear();

                while (BRR.PeekChar() != -1)
                {
                    codigo = BRR.ReadInt32();
                    descricao = BRR.ReadString();
                    categoria = BRR.ReadString();
                    preco = BRR.ReadInt32();

                    dataGridView1.Rows.Add(codigo, descricao, categoria, preco);
                }

                BRR.Close();
            }
            else
            {
                MessageBox.Show("O ficheiro não existe!");
            }
        }

        private bool ValiVazio()
        {
            bool valor = false;

            if(textBox1.Text  != "" &&
               textBox2.Text  != "" &&
               textBox4.Text  != "" &&
               comboBox1.Text != "")
            {
                valor = true;
            }

            return valor;
        }

        private void Limpar()
        {
            comboBox1.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }

        private void Registar()
        {
            bool valor = ValiVazio();

            if (valor)
            {
                codigo = int.Parse(textBox1.Text);
                descricao = textBox2.Text;
                categoria = comboBox1.Text;
                preco = int.Parse(textBox4.Text);

                FileStream registo = new FileStream(caminho, FileMode.Append, FileAccess.Write);
                BinaryWriter BR = new BinaryWriter(registo);

                BR.Write(codigo);
                BR.Write(descricao);
                BR.Write(categoria);
                BR.Write(preco);


                BR.Close();

                dataGridView1.Rows.Add(codigo, descricao, categoria, preco);

                Limpar();

                MessageBox.Show("Dados Registados com sucesso!");
                flag = true;   
            }
            else
            {
                MessageBox.Show("Tens que preencher todos os espaços!");
            }
        }

        // BUTTONS

        private void butto1_Click(object sender, EventArgs e)
        {
            Registar();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registar();
            if(flag == true)
            {
                Close();
            }
            else
            {
                var result = MessageBox.Show("Os dados não foram guardados, pretendes sair na mesma?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
            MessageBox.Show("Operação cancelada e dados limpos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
    }
}
