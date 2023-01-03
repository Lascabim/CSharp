using System;
using System.Windows.Forms;
using System.Media;

namespace M5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            painelDados.Visible = false;
            ShowData.Visible = false;
        }

        public struct Dados
        {
            public string nome;
            public string morada;
            public string telefone;
            public string telemovel;
            public string ec;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbox.Visible = false;
            painelDados.Visible = true;


        }

        private void painelDados_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show("Tens a certeza que pretendes registrar estes dados ?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                MessageBox.Show("Dados enviados com sucesso!");
                painelDados.Visible = false;
                gbox.Visible = true;
                int i = 0;
                Dados[] dados = new Dados[10];

                dados[i].nome = name.Text;
                dados[i].morada = adress.Text;
                dados[i].telefone = cellphone.Text;
                dados[i].telemovel = phone.Text;
                dados[i].ec = cv.Text;

                dataGridView1.Rows.Add(dados[i].nome, dados[i].morada, dados[i].telefone, dados[i].telemovel, dados[i].ec);


                name.Clear();
                adress.Clear();
                cellphone.Clear();
                phone.Clear();
                cv.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gusta\Downloads\quack2.wav");
                simpleSound.Play();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            name.Clear();
            adress.Clear();
            cellphone.Clear();
            phone.Clear();
            cv.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbox.Visible = false;
            ShowData.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gbox.Visible = true;
            ShowData.Visible = false;
            painelDados.Visible = false;
        }

        private void ShowData_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
                gbox.Visible = true;
                ShowData.Visible = false;
                painelDados.Visible = false;
        }
    }
}
