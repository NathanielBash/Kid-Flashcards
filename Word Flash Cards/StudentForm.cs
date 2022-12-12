using System;
using System.Windows.Forms;

namespace Word_Flash_Cards
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            txtStudentFirstName.Focus();

        }

        private void StudentDetails(StudentInfo Student)
        {
            if (txtStudentFirstName.Text != "")
            {
                Student.FirstName = txtStudentFirstName.Text;
            }
            else
            {
                txtStudentFirstName.Focus();
            }
            if (txtStudentLastName.Text != "")
            {
                Student.LastName = txtStudentLastName.Text;
            }
            else
            {
                txtStudentLastName.Focus();
            }
            if (txtAge.Text != "")
            {
                Student.Age = int.Parse(txtAge.Text);
            }
            else
            {
                txtAge.Focus();
            }
            if (cmbMonth.Text != "")
            {
                Student.DOBMonth = cmbMonth.Text;
            }
            else
            {
                cmbMonth.Focus();
            }
            if (txtDay.Text != "")
            {
                Student.DOBDay = int.Parse(txtDay.Text);
            }
            else
            {
                txtDay.Focus();
            }
            if (txtYear.Text != "")
            {
                Student.DOBYear = int.Parse(txtYear.Text);
            }
            else
            {
                txtYear.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfo myStudent = new StudentInfo();
            StudentDetails(myStudent);

            if (myStudent.FirstName != "")
            {
                MessageBox.Show(myStudent.FirstName.ToString() + " " + myStudent.LastName.ToString(), "Hello");
            }
            else
            {
                MessageBox.Show("Let's Begin");
            }

            FlashCardsForm myFlashCards = new FlashCardsForm();
            myFlashCards.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void birthdayCalander_DateChanged(object sender, DateRangeEventArgs e)
        {
            long LDay, LMonth, LYear;
            LDay = Convert.ToInt32(txtDay.Text);
            LMonth = Convert.ToInt32(cmbMonth.ToString());
            LYear = Convert.ToInt32(txtYear.Text);

            DateTime value = new DateTime(LDay + LMonth + LYear);

        }
    }
}
