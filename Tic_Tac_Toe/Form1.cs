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
            b.Enabled = false;
        }

        private void winnerCheck()
        {

        }
    }
}
