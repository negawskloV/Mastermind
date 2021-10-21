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
        int[] solution;
        public Form1()
        {
            InitializeComponent();
            solution = (int[])makeSolution();
        }

        List<Button> btnAttGeneratedList = new List<Button>();
        List<Button> btnResGeneratedList = new List<Button>();
        List<Color> solutionColors = new List<Color>();
        List<Color> attemptColors = new List<Color>();
        Color color;
        int turn = 0;
        string[] colorIndex = new string[8] { "Black", "White", "Red", "Blue", "Green", "Yellow", "Orange", "Purple" };


        public void Form1_Load(object sender, EventArgs e)
        {
            generateRow(0);
            int[] solution = (int[])makeSolution();
            int sol1 = solution[0];
            int sol2 = solution[1];
            int sol3 = solution[2];
            int sol4 = solution[3];
            Size = new Size(730, 550);
            solutionColors.Add(Color.FromName(colorIndex[sol1]));
            solutionColors.Add(Color.FromName(colorIndex[sol2]));
            solutionColors.Add(Color.FromName(colorIndex[sol3]));
            solutionColors.Add(Color.FromName(colorIndex[sol4]));
        }

        private void generateRow(int count)
        {
            generateAttRow(175, 120 + count * 66, 4, 60);
            generateResRow(439, 120 + count * 66, 27);
            if (count > 4)
            {
                Size = new Size(730, 350 + (55 * count));
            }
        }

        private void generateResRow(int startX, int startY, int size)
        {
            for (int i = 0; i < 2; i++)
            {
                generateResBtn(startX + i * (size + 6), startY, size);
                generateResBtn(startX + i * (size + 6), startY + 6 + size, size);
            }
        }

        private void generateResBtn(int x, int y, int size)
        {
            Button btnResult = new Button();
            btnResult.Width = size;
            btnResult.Height = size;
            btnResult.Left = x;
            btnResult.Top = y;
            btnResult.Enabled = false;
            this.Controls.Add(btnResult);
            btnResGeneratedList.Add(btnResult);
        }

        private void generateAttBtn(int x, int y, int size, int count, int i)
        {
            Button btnAttempt = new Button();
            btnAttempt.Name = "btnAttempt";
            btnAttempt.Width = size;
            btnAttempt.Height = size;
            btnAttempt.Left = x;
            btnAttempt.Top = y;
            btnAttempt.Click += new EventHandler(btnAttempt_Click);
            this.Controls.Add(btnAttempt);
            btnAttGeneratedList.Add(btnAttempt);

        }

        private void generateAttRow(int startX, int startY, int count, int size)
        {
            for (int i = 0; i < count; i++)
            {
                generateAttBtn(startX + i * (size + 6), startY, size, count, i);
            }
        }

        private Array makeSolution()
        {
            int[] solution = new int[4] { 0, 0, 0, 0 };
            Random rd = new Random();
            for (int i = 0; i < solution.Length; i++)
            {
                solution[i] = rd.Next(0, 7);
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

        private void btnAttempt_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = color;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (turn < 11)
            {
                int index = 0;
                int ind = 0;
                int correctCount = 0;
                turn++;
                for (int i = btnAttGeneratedList.Count - 4; i < btnAttGeneratedList.Count; i++)
                {
                    Button b = btnAttGeneratedList[i];
                    attemptColors.Add(b.BackColor);
                    bool matchPos = attemptColors[index].Equals(solutionColors[index]);
                    bool matchColor = attemptColors.Contains(solutionColors[index]);

                    if (matchPos == true)
                    {
                        Button b1 = btnResGeneratedList[btnResGeneratedList.Count - 4 + ind];
                        b1.BackColor = Color.Red;
                        ind++;
                        correctCount++;
                    }
                    else if (matchColor == true)
                    {
                        Button b1 = btnResGeneratedList[btnResGeneratedList.Count - 4 + ind];
                        b1.BackColor = Color.White;
                        ind++;
                    }
                    index++;

                }
                attemptColors.Clear();
                foreach (Button b in btnAttGeneratedList)
                {
                    b.Enabled = false;
                }
                if (correctCount == 4)
                {

                    btnSol1.BackColor = solutionColors[0];
                    btnSol2.BackColor = solutionColors[1];
                    btnSol3.BackColor = solutionColors[2];
                    btnSol4.BackColor = solutionColors[3];
                    MessageBox.Show("Congratulations \n YOU WIN!!");
                }
                else
                {
                    generateRow(turn);
                }
            }
            else
            {
                MessageBox.Show("Too bad, you lost. \n Press reset to restart and try again");
            }
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;
            Color selectedColor = btnClicked.BackColor;
            string selectedColorString = selectedColor.ToString();
            int colorLength = selectedColorString.Length;
            string selectedColorSubString = selectedColorString.Substring(7, colorLength - 8);
            label1.Text = "Selected color: \n" + selectedColorSubString;
            color = selectedColor;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
