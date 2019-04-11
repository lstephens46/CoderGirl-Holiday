using System;

namespace Holiday
{
    public static class Program
    {
        
        public static void Main()
        {
            DateTime leaving = DateTime.Today;
            //int daysGone = 7;
            DayReturning(leaving, 8);
            Console.ReadLine();
        }


        // TODO: Create a method that takes the day you are leaving on vacation and how many days you will be gone and return the name of the day of the week you will return.
        //((int)DayOfWeek.Monday - (int)DateTime.Today.DayOfWeek + 7) % 7) + 1);
        public static DayOfWeek DayReturning(DateTime leaving, int daysGone)
        {

            DayOfWeek dayReturning = leaving.AddDays(daysGone).DayOfWeek;
            
            Console.WriteLine(dayReturning);
            return dayReturning;
        }

    }
}
