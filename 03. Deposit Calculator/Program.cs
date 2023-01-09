using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine()); 
            double yearPercent = double.Parse(Console.ReadLine());
            double yearPercent1 = yearPercent/ 100;
            double monthlyEarning = deposit * yearPercent1; 
            double yearEarning = monthlyEarning / 12;
            double sum = deposit + yearEarning * months;
            Console.WriteLine(sum);
        }
    }
}
