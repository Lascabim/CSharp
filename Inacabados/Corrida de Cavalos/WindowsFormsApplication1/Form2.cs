using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dinheiro.Text = money.ToString();
            nivel.Text = level.ToString();
            subornar.Enabled = false;
            ctreinadores.Enabled = false;
            habilidade.Text = nextHab.ToString();
        }


        static int money = 5000;
        static int level = 1;
        static int preco, nextHab = 2;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dinheiro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ccavalos_Click(object sender, EventArgs e)
        {
            preco = 1000;
            
            if (money >= preco )
            {
                MessageBox.Show("Compras-te 1 cavalo", "STATUS");

                money = money - preco;
                level = level + 1;

                nivel.Text = level.ToString();
                dinheiro.Text = money.ToString();
                verificacao();
            }
            else
            {
                MessageBox.Show("Não tens dinheiro suficiente!");
            }
        }

        public void verificacao()
        {
            if (level > 1 && subornar.Enabled == false)
            {
                subornar.Enabled = true;
                nextHab = 4;     
                MessageBox.Show("PARABÉNS, DESBLOQUEAS-TE UMA NOVA HABILIDADE", "STATUS");
            }
            else if (level > 3 && ctreinadores.Enabled == false)
            {
                ctreinadores.Enabled = true;
                habilidade.Text = nextHab.ToString("NÍVEL MAX");
                MessageBox.Show("PARABÉNS, DESBLOQUEAS-TE UMA NOVA HABILIDADE", "STATUS");
            }
            else
            {
                subornar.Enabled = true;
                MessageBox.Show("JÁ TENS TODAS AS HABILIDADES DISPONÍVEIS PARA O NÍVEL ATUAL", "STATUS");
            }
            habilidade.Text = nextHab.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
