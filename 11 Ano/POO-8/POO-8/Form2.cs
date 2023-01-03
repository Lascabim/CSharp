using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using static POO_8.Form1;
using System.Runtime.InteropServices;

namespace POO_8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            ShowCont("", "");
        }

        public void ShowCont(string tipo, string telemovel)
        {
            string tempPath = System.IO.Path.GetTempPath();

            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }

            string filepath = tempPath + "/contactos.txt";

            if(File.Exists(filepath))
            {
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

                        if (tipo == "Search")
                        {
                            if (telemovel == contato)
                            {
                                MessageBox.Show(
                                    "Nome: " + nome + "\n" +
                                    "Contacto: " + telemovel + "\n" +
                                    "Data de Nascimento: " + dataN + "\n" +
                                    "Morada: " + morada + "\n" +
                                    "Nacionalidade: " + nacionalidade + "\n", "Contacto Encontrado\n");
                            }
                        }
                        else if (tipo == "Remove")
                        {
                            if (telemovel != contato)
                            {
                                dataGridView1.Rows.Add(nome, contato, dataN, morada, nacionalidade);
                            }
                        }
                        else if (tipo == "")
                        {
                            dataGridView1.Rows.Add(nome, contato, dataN, morada, nacionalidade);
                        }
                    }
                }
            }
            else
            {
                File.Create(filepath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string contactS = Interaction.InputBox("Contacto da procurar:");

            ShowCont("Search", contactS);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string contactS = Interaction.InputBox("Contacto a remover:");

            dataGridView1.Rows.Clear();
            ShowCont("Remove", contactS);
        }
    }
}
