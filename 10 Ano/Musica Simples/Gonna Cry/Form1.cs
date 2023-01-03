using System;
using System.Media;
using System.Windows.Forms;

namespace Gonna_Cry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer sSound = new SoundPlayer(@"C:\Users\Bandeira\Downloads\never.wav");
                sSound.Play();            
            }
        }
    }
}
