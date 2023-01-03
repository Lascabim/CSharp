using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Do_Galo_POO
{
    public partial class Form1 : Form
    {
        int Xplayer = 0, Oplayer = 0, Empates = 0, Rounds = 0;
        bool turnoX = true, jogo_final = false;
        string[] texto = new string[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;
            
            if(btn.Text == "" && jogo_final == false)
            {
                if (turnoX)
                {
                    btn.Text = "X";
                    texto[buttonIndex] = btn.Text;
                    Rounds++;
                    turnoX = (!turnoX);
                    Verify(1);
                }
                else
                {
                    btn.Text = "O";
                    texto[buttonIndex] = btn.Text;
                    Rounds++;
                    turnoX = (!turnoX);
                    Verify(2);
                }
            }
        }

        void Vencedor(int Vencedor)
        {
            jogo_final = true;

            if(Vencedor == 1)
            {
                Xplayer ++;
                Xpontos.Text = Convert.ToString(Xplayer);
                MessageBox.Show("Jogador X ganhou!");
                turnoX = true;
            }
            else
            {
                Oplayer++;
                Xpontos.Text = Convert.ToString(Xplayer);
                MessageBox.Show("Jogador O ganhou!");
                turnoX = false;
            }
        }

        void Verify(int VerifyPlayer)
        {
            string suport = "";

            if(VerifyPlayer == 1)
            {
                suport = "X";
            }
            else
            {
                suport = "O";
            }
        
            for (int horizontal = 0; horizontal < 8 ; horizontal += 3)
            {
                if(suport == texto[horizontal])
                {
                    if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2 ])
                    {
                        Vencedor(VerifyPlayer); 
                        return;
                    }
                }
            }

            for (int vertical = 0; vertical < 3; vertical ++)
            {
                if (suport == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        Vencedor(VerifyPlayer); 
                        return;
                    }
                }
            }

            if (texto[0 ] == suport)
            {
                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    Vencedor(VerifyPlayer); 
                    return;
                }
            }

            if (texto[2] == suport)
            {
                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                    Vencedor(VerifyPlayer); 
                    return;
                }
            }

            if(Rounds == 9 && jogo_final == false)
            {
                Empates++;
                EmpatesL.Text = Convert.ToString(Empates);

                MessageBox.Show("Empate!");
                jogo_final = true;
                return;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            
            Rounds = 0;
            jogo_final = false;
            for (int i = 0; i < 9; i++)
            {
                texto[i] = "";
            }
        }
    }
}
