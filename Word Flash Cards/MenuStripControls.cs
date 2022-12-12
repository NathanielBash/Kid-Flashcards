using System;

namespace Word_Flash_Cards
{
    class MenuStripControls
    {
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CountingForm_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void colorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void countingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountingForm myCountingForm = new CountingForm();
            myCountingForm.ShowDialog();
        }

        private void additionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MathForm myAddition = new MathForm();
            myAddition.ShowDialog();
        }

        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MathForm mySubtraction = new MathForm();
            mySubtraction.ShowDialog();
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MathForm myMultiplcation = new MathForm();
            myMultiplcation.ShowDialog();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MathForm myDivsion = new MathForm();
            myDivsion.ShowDialog();
        }
    }
}
