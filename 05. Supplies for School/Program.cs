using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pensCount = int.Parse(Console.ReadLine());
            int markersCount = int.Parse(Console.ReadLine()); 
            int litres = int.Parse(Console.ReadLine());   
            int discountPercent = int.Parse(Console.ReadLine());
            double sumPens = pensCount *5.80;
            double sumMarkers = markersCount *7.20;
            double sumLitres = litres *1.20;
            double sumAll = sumPens+sumMarkers+sumLitres;
            double discount = sumAll * discountPercent / 100;
            double finalAmmount = sumAll - discount;
            Console.WriteLine(finalAmmount);
        }
    }
}
