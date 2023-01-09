using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());
            double shoes = annualFee - (annualFee * 0.4);
            double set = shoes - (shoes * 0.2);
            double ball = set / 4;
            double accessoires = ball / 5;
            double sumAll = annualFee + shoes + set + ball + accessoires;
            Console.WriteLine(sumAll);
            

        }
    }
}
