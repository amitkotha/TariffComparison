using System;
using System.Collections.Generic;
using TariffComparison.Products;

namespace TariffComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your annual Consumption");
            string inputText = Console.ReadLine();
            if (inputText.IsNumeric())
            {
                int consumption = Convert.ToInt32(inputText);
                consumption = consumption > 0 ? consumption : 0;

                List<Tariff> tariffs = new List<Tariff>();
                tariffs.Add(new Tariff(new PackagedTariffProduct(), consumption));
                tariffs.Add(new Tariff(new BasicTariffProduct(), consumption));
                

                tariffs.Sort((x, y) => x.AnnualCost.CompareTo(y.AnnualCost));

                foreach(var tariff in tariffs)
                {
                    Console.WriteLine(tariff.TariffName+"--"+tariff.AnnualCost);
                }
                
            }
            Console.ReadLine();
        }
    }
}
