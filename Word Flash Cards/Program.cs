using System;
using System.Windows.Forms;

namespace Word_Flash_Cards
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Word_Flash_Cards.StudentForm());
        }
    }
}
