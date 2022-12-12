//Example code from other projects.
/* private void btnGenerate_Click(object sender, EventArgs e)
{
    StreamWriter outputFile;
    Random rand = new Random(100);

    // Define global variable
    int number = 0;
    double Max = 100;
    double Min = 1;
    double input;
    double i = 0;

    if (double.TryParse(txtInput.Text, out input))
    {
        if (input <= Max)
        {
            if (input >= Min)
            {
                // Select locaiton of where to save file
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text file|*.txt";
                saveFileDialog1.Title = "Save random number file";
                saveFileDialog1.ShowDialog();
                // Make sure it's a valid name for file not empty
                if (saveFileDialog1.FileName != "")
                {
                    outputFile = File.CreateText(saveFileDialog1.FileName);
                    while (i <= input)
                    {
                        number = rand.Next(100) + 1;
                        i++;
                        outputFile.WriteLine(number);
                    }
                    //Close the file and save the file
                    outputFile.Close();
                    txtInput.Focus();
                    txtInput.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a number more than 0");
            }
        }
        else
        {
            MessageBox.Show("Please enter a number less than 101");
        }
    }
}*/