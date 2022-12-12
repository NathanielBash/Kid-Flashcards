using System;
using System.Windows.Forms;

namespace Word_Flash_Cards
{
    public partial class CountingForm : Form
    {
        public CountingForm()
        {
            InitializeComponent();
            btnAdd1.Focus();
        }

        #region Declrations
        const int START = 0;
        int wholeNumber = START;

        #endregion

        private void CountingProgression()
        {
            btnAdd1.Enabled = true;

            if (wholeNumber >= 20)
            {
                btnAdd10.Visible = true;
                btnAdd10.Enabled = true;

                btnSubtract10.Visible = true;
                btnSubtract10.Enabled = true;
            }
            if (wholeNumber >= 100)
            {
                btnAdd100.Visible = true;
                btnAdd100.Enabled = true;

                btnSubtract100.Visible = true;
                btnSubtract100.Enabled = true;
            }

        }

        private void ShowProgress()
        {
            CountingProgression();
            if (wholeNumber <= 0)
            {
                progressBar1.Visible = false;
                progressBar1.Enabled = false;
            }
            else
            {
                progressBar1.Enabled = true;
                if (wholeNumber <= 1000)
                {
                    progressBar1.Visible = true;
                    progressBar1.Value = wholeNumber;
                }
                else if (wholeNumber > 999)
                {
                    DialogResult dialog = MessageBox.Show("Congratulations you counted to \n One-Thousand\n Do you want to restart?", "Exit", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else if (dialog == DialogResult.No)
                    {
                        MessageBox.Show("Ok, time to start subtracting!");
                        wholeNumber = 0;
                    }
                }
                else
                {
                    this.Close();
                }
            }

        }



        #region CountButtons
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            wholeNumber += 1;
            lblNumber.Text = wholeNumber.ToString();
            ShowProgress();
        }

        private void btnAdd10_Click_1(object sender, EventArgs e)
        {

            wholeNumber += 10;
            lblNumber.Text = wholeNumber.ToString();
            ShowProgress();
        }

        private void btnAdd100_Click_1(object sender, EventArgs e)
        {
            wholeNumber += 100;
            lblNumber.Text = wholeNumber.ToString();
            ShowProgress();
        }

        private void btnSubtract1_Click(object sender, EventArgs e)
        {
            wholeNumber -= 1;
            lblNumber.Text = wholeNumber.ToString();
            ShowProgress();
        }

        private void btnSubtract10_Click_1(object sender, EventArgs e)
        {
            wholeNumber -= 10;
            lblNumber.Text = wholeNumber.ToString();
            ShowProgress();
        }

        private void btnSubtract100_Click_1(object sender, EventArgs e)
        {
            wholeNumber -= 100;
            lblNumber.Text = wholeNumber.ToString();
            ShowProgress();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            const int MAXSIZE = 1000;
            int[] number = new int[MAXSIZE];
            Random rand = new Random();

            for (int index = 0; index < number.Length; index++)
            {
                number[index] = rand.Next(100);
            }
        }

        #endregion

        private void CountingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
