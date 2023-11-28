using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Kacper_Makosa_TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        int x_win = 0;
        int o_win = 0;

        public Form1()
        {
            InitializeComponent();
            textBox1.BackColor = Color.Aqua;
            textBox2.BackColor = Color.White;
        }

        private void button_click(object sender, EventArgs e)
        {


            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";

                textBox2.BackColor = Color.Aqua;
                textBox1.BackColor = Color.White;
            }
            else
            {
                b.Text = "O";
                textBox1.BackColor = Color.Aqua;
                textBox2.BackColor = Color.White;
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkwinner();
        }
        private void checkwinner()
        {
            bool winner = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                winner = true;
                
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                winner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                winner = true;
            }
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                winner = true;
            }
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                winner = true;
            }




            if (winner)
            {

                string win = " ";
                if (turn)
                {
                    win = "O";
                    o_win++;
                }
                else
                {
                    win = "X";
                    x_win++;
                }
                string message = "Gracz " + win + " wygra³." + " Jeszcze raz?";
                const string caption = "Wygrana!";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    A1.Enabled = true;
                    A2.Enabled = true;
                    A3.Enabled = true;
                    B1.Enabled = true;
                    B2.Enabled = true;
                    B3.Enabled = true;
                    C1.Enabled = true;
                    C2.Enabled = true;
                    C3.Enabled = true;

                    A1.Text = "";
                    A2.Text = "";
                    A3.Text = "";
                    B1.Text = "";
                    B2.Text = "";
                    B3.Text = "";
                    C1.Text = "";
                    C2.Text = "";
                    C3.Text = "";
                    turn = !turn;

                    turn_count = 0;
                    textBox1.BackColor = Color.Aqua;
                    textBox2.BackColor = Color.White;
                }
                else
                {
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                    turn = !turn;

                    turn_count = 0;
                }

                OText.Text = o_win.ToString();
                XText.Text = x_win.ToString();
            }
            else
            {
                if (turn_count == 9)
                {
                    string d_message = "Remis! To co dogrywka?";
                    const string d_caption = "Koniec gry!";
                    var draw = MessageBox.Show(d_message, d_caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (draw == DialogResult.Yes)
                    {

                        A1.Enabled = true;
                        A2.Enabled = true;
                        A3.Enabled = true;
                        B1.Enabled = true;
                        B2.Enabled = true;
                        B3.Enabled = true;
                        C1.Enabled = true;
                        C2.Enabled = true;
                        C3.Enabled = true;

                        A1.Text = "";
                        A2.Text = "";
                        A3.Text = "";
                        B1.Text = "";
                        B2.Text = "";
                        B3.Text = "";
                        C1.Text = "";
                        C2.Text = "";
                        C3.Text = "";
                        turn = !turn;
                        winner = false;
                        turn_count = 0;
                        textBox1.BackColor = Color.Aqua;
                        textBox2.BackColor = Color.White;
                    }
                    else
                    {
                        A1.Enabled = false;
                        A2.Enabled = false;
                        A3.Enabled = false;
                        B1.Enabled = false;
                        B2.Enabled = false;
                        B3.Enabled = false;
                        C1.Enabled = false;
                        C2.Enabled = false;
                        C3.Enabled = false;
                        turn = !turn;
                        winner = false;
                        turn_count = 0;
                    }
                }
            }

        }


    }
}