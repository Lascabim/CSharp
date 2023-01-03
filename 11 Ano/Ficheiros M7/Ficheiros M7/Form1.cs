using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ficheiros_M7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = @"c:\temp\pais.txt";
            string path2 = @"c:\temp\cidades.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {

                    while (sr.Peek() > -1)
                    {
                        listBox2.Items.Add(sr.ReadLine());

                    }
                }

            }
            else
            {
                File.Create(path);
            }

            if (File.Exists(path2))
            {
                using (StreamReader sr = new StreamReader(path2))
                {

                    while (sr.Peek() > -1)
                    {
                        listBox1.Items.Add(sr.ReadLine());

                    }
                }

            }
            else
            {
                File.Create(path2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string caixa = Interaction.InputBox("PAÍS", "INTRODUÇÃO DE PAÍSES");

            string path = @"c:\temp\pais.txt";

            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine(caixa);
            }
           
        }
    }
}
