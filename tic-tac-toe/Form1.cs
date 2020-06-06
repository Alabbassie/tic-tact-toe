using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class tic_tac_toe : System.Windows.Forms.Form
    {

        bool turn = true; // als het true = x beurt; false is y beurt
        int turn_count = 0;
       

        public tic_tac_toe()
        {
            InitializeComponent();
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void spelInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gemaaktDoorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gemaakt door Abbas Neimi", "info spel");
        }

        private void NewForm_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "x";
            else
                b.Text = "o";

            turn = !turn;
            b.Enabled = false;
            CheckForWinner();
            turn_count++;


        }
        private void CheckForWinner()
        {
            bool there_is_a_winner = false;
            //horizontaal controleren
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //verticaal controleren
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //diagonaal controleren
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;




            if (there_is_a_winner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                {
                    winner = "c";
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }

                else
                {
                    winner = "o";
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Gewonnen ", "gefeliciteerd!!");
            }
            else
            {
                if (turn_count == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("gelijkspel", "helaas!!");

                }
            }


        }//CheckForWinner kijkt wie er wint
        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType().Name == "Button")
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }

            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                if (c.GetType().Name == "Button")
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)

                    b.Text = "x";
                else
                    b.Text = "0";
            }


        }

       

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }

        }
    }
}
