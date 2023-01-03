using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto_Final_M10_Ze.Gestao;

namespace Projeto_Final_M10_Ze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bInscricoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Insc = new Form2();
            Insc.Show();
        }

        private void bRecibos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Recibos = new Form3();
            Recibos.Show();

        }

        private void bAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Admin = new Form4();
            Admin.Show();
        }
    }
}
