using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool jogador = true;
        int f = 1;
        int i = 0;

        public string Jogada (bool vez)
        {
            if(vez == true){
                jogador = false;
                f = 1;
                return "X";
            }
            else{
                jogador = true;
                f = 2;
                return "O";
            }
        }
        
        public void limpar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            i = 0;
        }

        private void acabo()
        {
            i++;
            if(btn1.Text == btn2.Text && btn1.Text == btn3.Text && btn1.Text != "" && btn2.Text != "" && btn3.Text != "")
            {
                MessageBox.Show($"Jogador {f} ganho");
                limpar();
            }
            else if(btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "" && btn5.Text != "" && btn6.Text != "")
            {
                MessageBox.Show($"Jogador {f} ganho");
                limpar();
            }
            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                MessageBox.Show($"Jogador {f} ganho");
                limpar();
            }
            else if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "" && btn4.Text != "" && btn7.Text != "")
            {
                MessageBox.Show($"Jogador {f} ganho");
                limpar();
            }
            else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "" && btn5.Text != "" && btn8.Text != "")
            {
                MessageBox.Show($"Jogador {f} ganho");
                limpar();
            }
            else if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "" && btn6.Text != "" && btn9.Text != "")
            {
                MessageBox.Show($"Jogador {f} ganho");
                limpar();
            }
            else if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "" && btn5.Text != "" && btn9.Text != "")
            {
                MessageBox.Show($"Jogador {f} ganho");
                limpar();
            }
            else if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "" && btn5.Text != "" && btn7.Text != "")
            {
                MessageBox.Show($"Jogador {f} ganho");
                limpar();
            }
            else if(i == 9)
            {
                MessageBox.Show($"Deu velha");
                limpar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(btn1.Text == "")
                btn1.Text = Jogada(jogador);
            acabo();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
                btn2.Text = Jogada(jogador);
            acabo();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
                btn3.Text = Jogada(jogador);
            acabo();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
                btn4.Text = Jogada(jogador);
            acabo();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
                btn5.Text = Jogada(jogador);
            acabo();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
                btn6.Text = Jogada(jogador);
            acabo();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
                btn7.Text = Jogada(jogador);
            acabo();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
                btn8.Text = Jogada(jogador);
            acabo();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
                btn9.Text = Jogada(jogador);
            acabo();
        }
    }
}