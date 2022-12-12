namespace Word_Flash_Cards
{
    class StudentInfo
    {
        public StudentInfo()
        {
            FirstName = "";
            LastName = "";
            Age = 0;

            DOBMonth = "";
            DOBDay = 0;
            DOBYear = 0;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public string DOBMonth { get; set; }
        public int DOBDay { get; set; }
        public int DOBYear { get; set; }




    }
}
