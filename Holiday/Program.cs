using System;

namespace Holiday
{
    public static class Program
    {
        public static void Main()
        {

            DateTime vacationDay = DateTime.Parse("03/20/2020");
            int vacationLength = 4;

            Console.WriteLine(DayReturning(vacationDay, vacationLength));
            Console.ReadLine();
        }

        // TODO: Create a method that takes the day you are leaving on vacation and how many days you will be gone and return the name of the day of the week you will return.

        public static DayOfWeek DayReturning(DateTime vacationDay, int vacationLength)
        {
            DateTime returnFromVacation = vacationDay.AddDays(vacationLength);
            DayOfWeek returnFromVacationDay = returnFromVacation.DayOfWeek;

            return returnFromVacationDay;
        }

        // TODO: Create a method that takes the day you are leaving on vacation and how many days you will be gone and return the name of the day of the week you will return.
    }
}
