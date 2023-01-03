using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto_Final_M10_Ze
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath();
            string filepath = tempPath + "/Minsc.txt";

            StreamReader sr;
            sr = new StreamReader(filepath);

            using (sr)
            {
                while (sr.Peek() > -1)
                {

                    string rawline = sr.ReadLine();
                    string nome, telemovel, nif, artePraticada = "";

                    int indexPause1 = 0, indexPause2 = 0, indexPause3 = 0, indexPause4 = 0;

                    indexPause1 = rawline.IndexOf('|', indexPause1);
                    indexPause2 = rawline.IndexOf('|', indexPause1 + 1);
                    indexPause3 = rawline.IndexOf('|', indexPause2 + 1);
                    indexPause4 = rawline.IndexOf('|', indexPause3 + 1);

                    nome = rawline.Substring(0, indexPause1);
                    //MessageBox.Show(nome);

                    telemovel = rawline.Substring(indexPause1 + 1, (indexPause2 - nome.Length) - 1);
                    //MessageBox.Show(telemovel);

                    nif = rawline.Substring(indexPause2 + 1, (indexPause3 - nome.Length - telemovel.Length - 2));
                    //MessageBox.Show(nif);

                    artePraticada = rawline.Substring(indexPause3 + 1, (indexPause4 - nome.Length - telemovel.Length - nif.Length - 3));
                    //MessageBox.Show(artePraticada);

                    if(artePraticada == "Nulo")
                    {
                        artePraticada = "Nenhuma";
                    }

                    dataGridView1.Rows.Add(nome, telemovel, nif, artePraticada);
                }
            }

            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Base = new Form1();
            Base.Show();
        }
    }
}
