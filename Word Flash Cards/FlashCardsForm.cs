using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Word_Flash_Cards
{
    public partial class FlashCardsForm : Form
    {
        #region Declrations 

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        StreamReader inputFile;
        List<string> Level = new List<string>();

        string Level1 = "SightWordsLevelA.txt";
        string Level2 = "SightWordsLevelB.txt";
        string Level3 = "SightWordsLevelC.txt";
        string Level4 = "Phonics.txt";
        string Level5 = "Vocab Builder.txt";
        string Level6 = "Dolch words.txt";
        string Level7 = "Word Familes.txt";
        string Level8 = "Action Verbs A to Z.txt";
        string Level9 = "Phonics Practice.txt";
        string Level10 = "200 most used words.txt";
        string Level11 = "Nouns.txt";
        string Level12 = "Verbs.txt";
        string Level13 = "Adjectives.txt";
        string Level14 = "Prepositions.txt";

        string Word;
        decimal TotalWords = 0;
        int Index = 0;

        #endregion  

        public FlashCardsForm()
        {
            InitializeComponent();
            menuStrip1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorTimer.Start();
            ColorTimer.Interval = 700;
        }

        #region Timers

        public string LetterHighlighting()
        {
            string WORD;
            WORD = txtWord.Text;
            return WORD;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ColorTime = new Random();

            int A = ColorTime.Next(0, 255);
            int R = ColorTime.Next(0, 255);
            int B = ColorTime.Next(0, 255);
            int G = ColorTime.Next(0, 255);

            txtWord.ForeColor = Color.FromArgb(G);

        }

        public void SlowDownTime()
        {
            SlowDown.Start();
            SlowDown.Interval = 7000;
        }

        public void SlowDown_Tick(object sender, EventArgs e)
        {
            SlowDownTime();
        }

        #region DisableButtons
        public void timer_Tick(object sender, System.EventArgs e)
        {
            btnNext.Enabled = true;
            btnExit.Enabled = true;
            timer.Stop();
            btnNext.Focus();
        }

        public void DelayActionDisable()
        {
            timer.Interval = 1050; // here time in milliseconds
            timer.Tick += timer_Tick;
            timer.Start();
            btnNext.Enabled = false;
            btnExit.Enabled = false;
        }
        #endregion


        //End of Timers region
        #endregion

        private void GetWords(StreamReader inputFile)
        {
            Level.Clear();
            Index = 0;
            TotalWords = 0;
            try
            {
                while (!inputFile.EndOfStream)
                {
                    Word = inputFile.ReadLine();
                    Level.Add(Word);
                    TotalWords = Level.Count;
                }
                inputFile.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to find file " + inputFile.ToString());
                throw;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            lblCount.Text = Index.ToString() + " / " + TotalWords.ToString();
            if (TotalWords == 0)
            {
                MessageBox.Show("Please select an option above.");
            }
            else
            {
                if (Index <= TotalWords)
                {
                    DelayActionDisable();

                    if (Index != TotalWords)
                    {
                        txtWord.Text = Level[Index].ToString();
                        Index += 1;
                        SlowDownTime();
                    }
                    else
                    {
                        MessageBox.Show("You did it");
                    }
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You clicked exit are you finished?", "Finish", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                StudentInfo currentStudent = new StudentInfo();

                MessageBox.Show("Good job " + currentStudent.FirstName);
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Pick another menu item.");
            }
        }

        #region Menu Strip

        #region Words Menu Strip

        private void level1ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level1);
            GetWords(inputFile);
        }

        private void level2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level2);
            GetWords(inputFile);
        }

        private void level3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level3);
            GetWords(inputFile);
        }

        private void level4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level4);
            GetWords(inputFile);
        }

        private void level5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level5);
            GetWords(inputFile);
        }

        private void level6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level6);
            GetWords(inputFile);
        }

        private void level7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level7);
            GetWords(inputFile);
        }

        private void level8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level8);
            GetWords(inputFile);
        }
        private void level9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level9);
            GetWords(inputFile);
        }
        private void mostCommonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level10);
            GetWords(inputFile);
        }

        private void nounsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level11);
            GetWords(inputFile);
        }

        private void verbsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level12);
            GetWords(inputFile);
        }

        private void adjutivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level13);
            GetWords(inputFile);
        }

        private void prepositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputFile = File.OpenText(Level14);
            GetWords(inputFile);
        }
        #endregion

        #region Math Menu Strip
        private void countingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void additionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Colors / Shapes Menu Strip

        private void colorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorsForm myColors = new ColorsForm();
            myColors.ShowDialog();

        }


        private void shapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region Music Notes
        private void timeSignatureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void symbolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trebleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        # region To Fix

        private void countingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CountingForm myCountingForm = new CountingForm();
            myCountingForm.ShowDialog();
        }

        private void additionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MathForm myAddition = new MathForm();
            myAddition.SetTextForLabel("+");
            myAddition.ShowDialog();
        }

        private void subtractionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MathForm mySubtraction = new MathForm();
            mySubtraction.SetTextForLabel("-");
            mySubtraction.ShowDialog();
        }

        private void multiplcationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MathForm myMultiplcation = new MathForm();
            myMultiplcation.SetTextForLabel("*");
            myMultiplcation.ShowDialog();
        }

        private void divisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MathForm myDivsion = new MathForm();
            myDivsion.SetTextForLabel("/");
            myDivsion.ShowDialog();
        }

        private void shapesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShapesForm myShape = new ShapesForm();
            myShape.ShowDialog();
        }

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void moneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoneyForm myMoney = new MoneyForm();
            myMoney.ShowDialog();
        }
        #endregion

        private void Typing()
        {
            int MAXTRY = 2;
            int ATTEMPTS = 0;

            if (txtTyping.Text == Level[Index].ToString()) ;


        }

        private void typingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTyping.Enabled = true;
            txtTyping.Visible = true;
        }
    }
}
