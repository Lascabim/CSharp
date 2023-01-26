using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoStocks
{
    public partial class EditForms : Form
    {
        public EditForms(string nome, string preco, string quantidade)
        {
            InitializeComponent();
            label1.Text = nome;
            label3.Text = "Preço Atual = " + preco;
            label4.Text = "Quantidade Atual = " + quantidade + " unidades";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AddP = new AddProduct();
            AddP.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precoNovo = Convert.ToDouble(textBox1.Text);
            double quantidadeNova = Convert.ToDouble(textBox2.Text);
            
            if(precoNovo != nome)
            {
                MessageBox.Show("ESTOU AQUI");
            }
        }
    }
}
