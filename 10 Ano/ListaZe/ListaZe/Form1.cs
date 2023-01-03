using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ListaZe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Alunos
        {
            public int num;
            public string nome;
            public double nota;
        }

        ArrayList lista = new ArrayList();
        Alunos p = new Alunos();
        static int cont = 0;
        static string erro = "Introdução Inválida, introduz os campos todos de forma correta!";

        private void Listar()
        {
            dataGridView1.Rows.Clear();
            foreach (Alunos p in lista)
            {
                dataGridView1.Rows.Add(p.num, p.nome, p.nota);  
            }
        }

        public bool Repeticao()
        {
            int z = 0;
            if (cont != 0)
            {
                foreach (Alunos p in lista)
                {
                    if (int.Parse(textBox1.Text) != p.num)
                    {
                        z = 1;
                    }
                }
                if (z == 1)
                {
                    return true;
                }
                else
                {
                    erro = "Esse número de aluno já existe!";
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool z = Repeticao();
            if(z)
            {
                p.num = int.Parse(textBox1.Text);
                p.nome = textBox2.Text;
                p.nota = double.Parse(textBox3.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                lista.Add(p);
                cont++;
                MessageBox.Show("Dados Adicionados", "INFO");
            }
            else
            {
                MessageBox.Show(erro);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cont > 0)
            {
                Listar();
            }
            else
            {
                MessageBox.Show("Ainda não foram introduzidos alunos!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                int pos = int.Parse(Interaction.InputBox("Número da pessoa que pretendes procurar? "));
                int y = 0;

                foreach(Alunos p in lista)
                {
                    if (p.num == pos)
                    {
                        y = 1;
                        MessageBox.Show("Nome: "+ p.nome + "\nNúmero: "+ p.num + "\nNota: "+ p.nota, "PESSOA ENCONTRADA");
                        break;
                    }
                }
                if(y == 0)
                {
                    MessageBox.Show("Pessoa não encontrada!");
                }
            }
            else
            {
                MessageBox.Show("Ainda não foram introduzidos alunos!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                int y = 0;
                string pos = Interaction.InputBox("Introduz o número da pessoa a remover!");

                foreach (Alunos p in lista)
                {
                   if (p.num.ToString() == pos)
                   {
                        var result = MessageBox.Show("Pretendes eliminar o aluno número " + p.num + "?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            lista.Remove(p);
                            MessageBox.Show("Aluno removido!");
                            Listar();
                            y = 1;
                            cont--;
                            break;
                        }
                   }
                }
                if (y == 0)
                {
                   MessageBox.Show("Aluno não encontrado!");
                }
            }
            else
            {
                MessageBox.Show("Ainda não foram introduzidos alunos!");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cont > 0 && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                string pos = Interaction.InputBox("Posição da pessoa onde pretendes inserir? ");
               
                if(int.Parse(pos) < (cont + 2) && int.Parse(pos) > 0)
                {
                    p.num = int.Parse(textBox1.Text);
                    p.nome = textBox2.Text;
                    p.nota = double.Parse(textBox3.Text);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    lista.Insert(int.Parse(pos) - 1, p);
                }
                else
                {
                    MessageBox.Show("Introduz uma posição válida!");
                }
            }
            else
            {
                MessageBox.Show(erro);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Pretendes fechar o programa?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Close();
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(cont != 0)
            {
                var result = MessageBox.Show("Pretendes apagar os dados?", "Confirmação",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cont = 0;
                    dataGridView1.Rows.Clear();
                    lista.Clear();
                    MessageBox.Show("Dados Apagados");
                }
            }
            else
            {
                MessageBox.Show("Ainda não há alunos!");
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void NumBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void NotaBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
