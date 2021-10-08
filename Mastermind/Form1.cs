using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
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

        private void btnHowTo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The aim of the game is to crack the code. \n " +
                "You will be given a code by the computer and your goal is to find out what that code is. \n\n " +
                "First you place what you think the code is, then you click \"Submit Attempt\".\n " +
                "Then you will see white and red pins appear next to your attempt, a white pin indicates that one of the pins in your attempt is the correct color, but not the correct position. A red pin indicates that a pin in your attempt is both the correct color and position. \n\n " +
                "Once you guess the code correctly: YOU WIN!!");
        }
    }
}
