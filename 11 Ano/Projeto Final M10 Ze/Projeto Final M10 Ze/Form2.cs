using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static Projeto_Final_M10_Ze.Gestao;

namespace Projeto_Final_M10_Ze
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files(*.*)|*.*|JPG Files|*.jpg*|PNG Files|*.png*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar a imagem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Base = new Form1();
            Base.Show();
        }

        private void ClearInputs()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = false;

            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insc insc = new Insc();

            insc.nome = textBox4.Text;
            insc.telemovel = textBox2.Text;
            insc.nif = textBox3.Text;

            if(checkBox1.Checked)
            {
                insc.japraticou = true;
            }
            else
            {
                insc.japraticou = false;
            }

            bool readyToGo =  insc.CheckInscInput();

            if (readyToGo)
            {
                ClearInputs();
                MessageBox.Show("Aluno incrito com sucesso!");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
