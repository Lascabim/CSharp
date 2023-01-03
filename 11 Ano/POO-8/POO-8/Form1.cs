using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace POO_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        public class Registo
        {
            public string nome, morada, nacionalidade, contactoString, dateString;
            public double contacto;
            public string[] DN = new string[3];

            public void SaveContact()
            {
                string tempPath = System.IO.Path.GetTempPath();

                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                }

                string filepath = tempPath + "/contactos.txt";

                bool notR = true;

                using (StreamReader sr = new StreamReader(filepath))
                {
                    while (sr.Peek() > -1)
                    {
                        //INFO
                        string rawline = sr.ReadLine();

                        string dataN, nome, contato, morada, nacionalidade;
                        int indexPause = 0, indexPause2 = 0, indexPause3 = 0, indexPause4 = 0, indexPause5 = 0;

                        indexPause = rawline.IndexOf('|', indexPause);
                        indexPause2 = rawline.IndexOf('|', indexPause + 1);
                        indexPause3 = rawline.IndexOf('|', indexPause2 + 1);
                        indexPause4 = rawline.IndexOf('|', indexPause3 + 1);
                        indexPause5 = rawline.IndexOf('|', indexPause4 + 1);

                        dataN = rawline.Substring(0, indexPause);
                        nome = rawline.Substring(indexPause + 1, (indexPause2 - dataN.Length) - 1);
                        contato = rawline.Substring(indexPause2 + 1, (indexPause3 - dataN.Length - nome.Length) - 2);
                        morada = rawline.Substring(indexPause3 + 1, (indexPause4 - dataN.Length - nome.Length - contato.Length) - 3);
                        nacionalidade = rawline.Substring(indexPause4 + 1, (indexPause5 - dataN.Length - nome.Length - contato.Length - morada.Length) - 4);

                        if(contactoString == contato)
                        {
                            notR = false;
                        }
                    }

                }

                if(notR)
                {
                    FileStream file;
                    file = new FileStream(filepath, FileMode.Append, FileAccess.Write);

                    if(morada == "")
                    {
                        morada = "Desconhecida";
                    }

                    if (nacionalidade == "")
                    {
                        nacionalidade = "Desconhecida";
                    }

                    using (StreamWriter writetext = new StreamWriter(file))
                    {
                        writetext.WriteLine(DN[0] + "/" + DN[1] + "/" + DN[2] + "|" + nome + "|" + contactoString + "|" + morada + "|" + nacionalidade + "|");
                    }

                    MessageBox.Show("Contacto Adicionado com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Contacto Repetido");
                }

            }

            public void GetDate()
            {
                DN[0] = dateString.Substring(0, 2);   
                DN[1] = dateString.Substring(3, 2);   
                DN[2] = dateString.Substring(6, 4);
            }

            public bool CheckRequirements()
            {
                bool check = false;

                if(nome != "" && contactoString != "")
                {
                    check = true;
                }

                return check;
            }

            public bool CheckPhone()
            {
                bool check = false;

                if (contactoString.Length == 9)
                {
                    string num = contactoString.Substring(0, 1);

                    if (num == "9")
                    {
                        check = true;
                    }
                    else
                    {
                        MessageBox.Show("Contacto Inválido");
                    }
                }
                else
                {
                    MessageBox.Show("Contacto Demasiado Curto");
                }

                return check;
            }
        }

        /*
            public void CleanInputs()
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            Registo reg = new Registo();

            reg.nome = textBox1.Text;
            reg.contactoString = textBox2.Text;
            reg.morada = textBox4.Text;
            reg.nacionalidade = textBox3.Text;
            reg.dateString = dateTimePicker1.Value.ToShortDateString();
            reg.GetDate();

            bool check = reg.CheckRequirements();

            if(check)
            { 
                reg.contacto = Convert.ToDouble(textBox2.Text);
                bool check2 = reg.CheckPhone();

                if (check2)
                {
                    reg.SaveContact();
                }
            }
            else
            {
                MessageBox.Show("Tens que preencher os campos obrigatórios corretamente!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath();

            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }

            string filepath = tempPath + "/contactos.txt";

            if (File.Exists(filepath))
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                MessageBox.Show("Não tens nenhum contacto adicionado!");
            }

        }
    }
}
