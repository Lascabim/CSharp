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
        static string tempPath = System.IO.Path.GetTempPath();
        static string filepathPM = tempPath + "/SMprodutosM.txt";
        static StockClass sc = new StockClass();

        public EditForms(string nome, string preco, string quantidade)
        {
            InitializeComponent();
            label1.Text = nome;
            label3.Text = "Preço Atual = " + preco;
            label4.Text = "Quantidade Atual = " + quantidade + " unidades";

            quantidadeT.Text = quantidade;
            quantidadeT.Visible = false;

            precoT.Text = preco;
            precoT.Visible = false;
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
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Tens que escolher um método de saída!");
            }
            else
            {
                int LengthprecoAtual = (precoT.Text.Length);
                string precoAtual = (precoT.Text);
                string precoAtualF = precoAtual.Substring(0, LengthprecoAtual - 2);

                double precoNovo = Convert.ToDouble(precoAtualF);
                double quantidadeNova = Convert.ToDouble(quantidadeT.Text);

                string tipoDado = "Tipo de Saida";

                if(radioButton1.Checked)
                {
                    tipoDado = "Online";
                }
                else if (radioButton2.Checked)
                {
                    tipoDado = "Pessoal";
                }
                else if(radioButton3.Checked)
                {
                    tipoDado = "Loja";
                }

                if (textBox1.Text != "" && textBox1.Text != null && textBox2.Text != "" && textBox2.Text != "")
                {
                    DialogResult confirmation = MessageBox.Show("Pretendes confirmar a edição do produto?", "Editar Produto", MessageBoxButtons.YesNo);
                    if (confirmation == DialogResult.Yes)
                    {
                        DateTime dateTime = DateTime.UtcNow.Date;
                        string dataAtual = dateTime.ToString("dd/MM/yyyy");

                        string nP = textBox1.Text;
                        string nQ = textBox2.Text;
                        string lA = label1.Text;
                        sc.EditProduct(nP, nQ, lA, dataAtual);


                        double oldQuantity = Convert.ToDouble(quantidadeT.Text);
                        double newQuantity = Convert.ToDouble(nQ);
                        double HnQ;

                        if (newQuantity == oldQuantity)
                        {
                            HnQ = newQuantity;
                        }
                        else
                        {
                            HnQ = (newQuantity - oldQuantity);
                        }

                        sc.UpdateHistory(HnQ, lA, dataAtual, tipoDado);
                    }
                }
                else
                {
                    MessageBox.Show("Introduz valores válidos !");
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
