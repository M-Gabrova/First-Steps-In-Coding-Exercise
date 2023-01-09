using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine())+2;
            double paint = double.Parse(Console.ReadLine());
            int litres = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double paint1 = paint * 0.1;
            double paintSum = (paint1+paint)*14.50;
            double allExpences = nylon*1.5 + paintSum + litres * 5 + 0.40;
            double sumWork = (allExpences * 0.3)*hours;
            double sumAll = sumWork + allExpences;
            Console.WriteLine(sumAll);

        }
    }
}
