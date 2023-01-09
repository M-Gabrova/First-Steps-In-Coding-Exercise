using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesTotal = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hoursPerBook = pagesTotal/pagesPerHour;
            int hoursPerDay = hoursPerBook/days;
            Console.WriteLine(hoursPerDay);
        }
    }
}
