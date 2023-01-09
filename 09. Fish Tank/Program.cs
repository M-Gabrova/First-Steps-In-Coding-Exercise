using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dulj = int.Parse(Console.ReadLine());
            int shir = int.Parse(Console.ReadLine());
            int vis = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine())/100;
            int volume = dulj * shir * vis;
            double volumeLitres = volume * 0.001;
            double waterLitres = volumeLitres * (1 - percent);
            Console.WriteLine(waterLitres);
        }
    }
}
