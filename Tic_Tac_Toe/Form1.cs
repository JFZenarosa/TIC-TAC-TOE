using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = X, False = O
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By: Zenarosa, Jaireh F. OOP Assignment 3 TIC_TAC_TOE");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (turn)
                a.Text = "X";
            else
                a.Text = "O";

            turn = !turn;
            a.Enabled = false;
            turn_count++;

            winnerCheck();
        }

        private void winnerCheck()
        {
            bool the_winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                the_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                the_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                the_winner = true;


            if(the_winner)
            {
                disableBtns();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Wins the Game!", "Congratulations!");
            }
            else
            {
                if(turn_count == 9)
                    MessageBox.Show("DRAW!", "Try Again!");
            }
        }

        private void disableBtns()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button a = (Button)c;
                    a.Enabled = false;
                }
            }
            catch { }
        }
    }
}
