using System;

namespace Exercise5
{
    class Date
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        //Date constructor
        public Date (int Day, int Month, int Year)
        {
            day = Day;
            month = Month;
            year = Year;
        }
        //Checks if date is somewhat  "correct".
        //Returns true if days are less or equal to 31 and if months are less and equal to 12
        private bool IsDateCorrect()
        {
            return day < 32 && month < 13;
        }
        //Prints date or "Date is not correct", if date is not correct
        public void PrintDate()
        {
            if (IsDateCorrect())
            {
                Console.WriteLine($"{String.Format("{0:00}", day)}/{String.Format("{0:00}", month)}/{year}");
            }
            else
            {
                Console.WriteLine("Date is not correct");
            }
        }
    }
}
