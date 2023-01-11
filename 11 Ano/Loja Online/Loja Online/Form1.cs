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
using System.Data.SqlClient;

namespace Loja_Online
{

    public partial class Form1 : Form
    {
        static string actualType = "M";

        public Form1()
        {

            InitializeComponent();

            panel2.Visible = true;
            btnMas.BackColor = Color.White;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public string sendData(string item, string preco)
        {

            string tempPath = System.IO.Path.GetTempPath();

            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }

            //MessageBox.Show(tempPath);

            string filepath = tempPath + "/pedidos.txt";

            //string moradaIN = Interaction.InputBox("Introduz a morada: ", "Envio de pedido!");

            FileStream file;
            file = new FileStream(filepath, FileMode.Append, FileAccess.Write);

            string moradaIN = "Morada do Cliente";

            Random random = new Random();
            int idGen = random.Next(1000);

            using (StreamWriter writetext = new StreamWriter(file))
            {
               writetext.WriteLine("Items:" + item + "|" + preco + "|" + moradaIN + "|30/09/2022|" + "ID" + idGen + "|");
            }

            file.Close();

            //MessageBox.Show("O pedido foi enviado com sucesso, relembra-mos que o pagamento é efetuado em dinheiro na hora!");

            return "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string password = (Interaction.InputBox("Introduz a password: ", "Gestão da Loja")).ToLower();

            if (password == "admin")
            {
                this.Hide();
                var StaffForm = new Form2();
                StaffForm.Show();
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (actualType == "F")
            {
                //btnFem.BackColor = Color.Transparent;
                btnMas.BackColor = Color.White;
                actualType = "M";
            }
        }

        private void btnFem_Click(object sender, EventArgs e)
        {

            if (actualType == "M")
            {
                btnMas.BackColor = Color.Transparent;
                //btnFem.BackColor = Color.White;
                actualType = "F";
            }
        }

        private void btnRelogios_Click(object sender, EventArgs e)
        {
            //panel2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendData("Relógio", "50");
            MessageBox.Show("Produto adicionado ao carrinho!");
        }

        private void btnAneis_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendData("Colár", "25");
            MessageBox.Show("Produto adicionado ao carrinho!");
        }

        private void btnColares_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sendData("Anél", "15");
            MessageBox.Show("Produto adicionado ao carrinho!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath();
            string filepath = tempPath + "/pedidos.txt";


            if (!File.Exists(filepath))
            {
                File.Create(filepath);
            }

            var info = new FileInfo(filepath);
            if (info.Length == 0)
            {
                MessageBox.Show("Carrinho vazio!");

            }
            else
            {
                this.Hide();

                Carrinho form = new Carrinho();
                form.Show();
            }
        }
    }
}
