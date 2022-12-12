//Refrencess: Accessing a lable from class https://stackoverflow.com/questions/8833665/access-label-on-one-form-from-another-class 


using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Word_Flash_Cards
{
    public partial class MathForm : Form

    {
        public MathForm()
        {
            InitializeComponent();
            GenerateQuestion();
            txtAnswer.Focus();
            lblOperator.Text = "+";
        }
        #region Declrations
        const int SIZE = 2;
        int[] mathNumbers = new int[SIZE];
        int attempts = 0;
        const int MAXATTEMPTS = 3;

        int Answer;
        int answerAddtion;
        int answerSubtraction;
        decimal answerDivison;
        int answerMultiplcation;
        int X;
        int Y;

        #endregion

        public void Grading(StreamWriter outputFile)
        {
            //    ' Writes a Grading file for the teacher
            //Dim file As System.IO.StreamWriter
            //file = My.Computer.FileSystem.OpenTextFileWriter("Grading.txt", True)

            //file.WriteLine(txtStudent.Text)
            //file.WriteLine("Correct")
            //file.WriteLine(Correct.Count)
            //file.WriteLine("Inncorrect")
            //file.WriteLine(Inncorrect.Count)
            //file.WriteLine(Menu)
            //'file.WriteLine(giveUps.count)
            //file.WriteLine(Menu)
            //file.WriteLine(difficultyChecked)
            //file.Close()
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file|*.txt";
            saveFileDialog1.Title = "Save progress to file";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                outputFile = File.CreateText(saveFileDialog1.FileName);

            }
            outputFile.Close();
            txtAnswer.Focus();
            txtAnswer.Text = "";
        }

        public void GenerateQuestion()
        {
            Random randNumber = new Random();
            int easy = 5;
            int intermediate = 9;
            int hard = 12;

            if (rbtnEasy.Checked == true)
            {
                for (int index = 0; index < mathNumbers.Length; index++)
                {
                    mathNumbers[index] = randNumber.Next(easy);
                }
            }
            else if (rbtnIntermediate.Checked == true)
            {
                for (int index = 0; index < mathNumbers.Length; index++)
                {
                    mathNumbers[index] = randNumber.Next(intermediate);
                }
            }
            else if (rbtnHard.Checked == true)
            {
                for (int index = 0; index < mathNumbers.Length; index++)
                {
                    mathNumbers[index] = randNumber.Next(hard);
                }
            }

            lblNumberOne.Text = mathNumbers[0].ToString();
            lblNumberTwo.Text = mathNumbers[1].ToString();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Operator();
            if (txtAnswer.Text != "")
            {
                if (attempts != MAXATTEMPTS)
                {
                    if (txtAnswer.Text == Answer.ToString())
                    {
                        lblResponse.Text = "Correct";
                    }
                    else
                    {
                        attempts++;
                        lblResponse.Text = "Try again";
                    }
                }
                else
                {
                    lblResponse.Text = "The answer is " + Answer.ToString();
                }
            }
            else
            {
                lblResponse.Text = "Please enter your answer.";
                txtAnswer.Focus();
            }
        }
        private void Operator()
        {
            X = Convert.ToInt32(lblNumberOne.Text);
            Y = Convert.ToInt32(lblNumberTwo.Text);

            if (lblOperator.Text == "+")
            {
                answerAddtion = mathNumbers.Sum();
                Answer = answerAddtion;
            }
            else if (lblOperator.Text == "-")
            {
                answerSubtraction = X - Y;
                Answer = answerSubtraction;
            }
            else if (lblOperator.Text == "*")
            {
                answerMultiplcation = X * Y;
                Answer = answerMultiplcation;
            }
            else if (lblOperator.Text == "/")
            {
                answerDivison = X / Y;
                Answer = decimal.ToInt32(answerDivison);
            }

        }
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "The answer is " + Answer.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            attempts = 0;

            lblNumberOne.Text = "";
            lblNumberTwo.Text = "";

            lblResponse.Text = "";
            txtAnswer.Text = "";
            GenerateQuestion();
            txtAnswer.Focus();

        }

        public string SetTextForLabel(string myText)
        {
            this.lblOperator.Text = myText;
            return myText;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnHard_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

