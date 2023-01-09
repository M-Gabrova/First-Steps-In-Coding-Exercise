using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vege = int.Parse(Console.ReadLine());
            double menusSum = chicken *10.35 +fish *12.40 +vege *8.15;
            double desert = menusSum * 0.20;
            double sumAll = 2.5 + desert + menusSum;
            Console.WriteLine(sumAll);
        }
    }
}
