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

        int turn = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            generateRow(0);

        }

        private void generateRow(int count)
        {
            generateAttRow(175, 120 + count * 66, 4, 60);
            generateResRow(439, 120 + count * 66, 27);
        }

        private void generateResRow(int startX, int startY, int size)
        {
            for (int i = 0; i < 2; i++)
            {
                generateBtn(startX + i * (size + 6), startY, size);
                generateBtn(startX + i * (size + 6), startY + 6 + size, size);
            }
        }

        private void generateBtn(int x, int y, int size)
        {
            Button button = new Button();
            button.Width = size;
            button.Height = size;
            button.Left = x;
            button.Top = y;
            this.Controls.Add(button);
        }

        private void generateAttRow(int startX, int startY, int count, int size)
        {
            for (int i = 0; i < count; i++)
            {
                generateBtn(startX + i * (size + 6), startY, size);
            }
        }

        private Array makeSolution()
        {
            int[] solution = new int[4] { 0, 0, 0, 0 };
            Random rd = new Random();
            for (int i = 0; i < solution.Length; i++)
            {
                solution[i] = rd.Next(1,8);
            }
            return solution;
        }

        private void btnHowTo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The aim of the game is to crack the code. \n " +
                "You will be given a code by the computer and your goal is to find out what that code is. \n\n " +
                "First you place what you think the code is, then you click \"Submit Attempt\".\n " +
                "Then you will see white and red pins appear next to your attempt, a white pin indicates that one of the pins in your attempt is the correct color, but not the correct position. A red pin indicates that a pin in your attempt is both the correct color and position. \n\n " +
                "Once you guess the code correctly: YOU WIN!!");

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (turn < 11)
            {
                turn++;
                generateRow(turn);
            }
            int[] solution = (int[])makeSolution();
            int sol1 = solution[0];
            int sol2 = solution[1];
            int sol3 = solution[2];
            int sol4 = solution[3];
            MessageBox.Show(sol1 + ", " + sol2 + ", " + sol3 + ", " + sol4);
        }
    }
}
