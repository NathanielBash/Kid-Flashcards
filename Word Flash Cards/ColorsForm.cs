using System;
using System.Drawing;
using System.Windows.Forms;

namespace Word_Flash_Cards
{
    public partial class ColorsForm : Form
    {
        public ColorsForm()
        {
            InitializeComponent();
        }

        #region Color Names

        enum Spectrum
        {
            Red, Orange, Yellow, Green, Blue, Purple, Pink
        }
        private void DisplayColor(Spectrum color)
        {
            colorLabel.Text = "";
            colorLabel.Text = color.ToString();
        }
        private void redLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Red);
        }

        private void orangeLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Orange);
        }

        private void yellowLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Yellow);
        }

        private void greenLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Green);
        }

        private void blueLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Blue);
        }

        private void indigoLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Purple);
        }

        private void violetLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Pink);
        }
        #endregion

        private void btnMix_Click(object sender, EventArgs e)
        {
            #region Color Mixer

            grpFirstColor.ForeColor = Color.White;
            grpSecondColor.ForeColor = Color.White;
            btnMix.ForeColor = Color.Black;
            btnExit.ForeColor = Color.Black;

            try
            {
                // Just red button checked
                if (rbtnRed1.Checked) { grpColorMixer.BackColor = Color.Red; }

                if (rbtnRed2.Checked) { grpColorMixer.BackColor = Color.Red; }

                // Just blue button checked
                if (rbtnBlue1.Checked) { grpColorMixer.BackColor = Color.Blue; }

                if (rbtnBlue2.Checked) { grpColorMixer.BackColor = Color.Blue; }

                // Just yellow button checked
                if (rbtnYellow1.Checked) { grpColorMixer.BackColor = Color.Yellow; }

                if (rbtnYellow2.Checked) { grpColorMixer.BackColor = Color.Yellow; }

                //If rbtnRed1 & mix is checked.
                if (rbtnRed1.Checked & rbtnRed2.Checked) { grpColorMixer.BackColor = Color.Red; }

                else if (rbtnRed1.Checked & rbtnBlue2.Checked) { grpColorMixer.BackColor = Color.Purple; }

                else if (rbtnRed1.Checked & rbtnYellow2.Checked) { grpColorMixer.BackColor = Color.Orange; }

                //If rbtnBlue1 & mix is checked
                if (rbtnBlue1.Checked & rbtnRed2.Checked) { grpColorMixer.BackColor = Color.Purple; }

                else if (rbtnBlue1.Checked & rbtnBlue2.Checked) { grpColorMixer.BackColor = Color.Blue; }

                else if (rbtnBlue1.Checked & rbtnYellow2.Checked) { grpColorMixer.BackColor = Color.Green; }

                // If rbtnYellow1 & mix is checked.
                if (rbtnYellow1.Checked & rbtnRed2.Checked) { grpColorMixer.BackColor = Color.Orange; }

                else if (rbtnYellow1.Checked & rbtnBlue2.Checked) { grpColorMixer.BackColor = Color.Green; }

                else if (rbtnYellow1.Checked & rbtnYellow2.Checked) { grpColorMixer.BackColor = Color.Yellow; }

            }
            catch (Exception)
            {

                MessageBox.Show("Please make a selection");
            }

            #endregion
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
