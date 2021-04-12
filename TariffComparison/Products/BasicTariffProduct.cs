using System;


namespace TariffComparison.Products
{
    public class BasicTariffProduct : IProduct
    {
        public string Name
        {
            get { return "Basic Electricity Tariff"; }
        }
        public double CalculationModel(int consumption)
        {
            double baseCost = 60; //(5*12)
            double consumptionCosts = consumption * 0.22;
            return baseCost + consumptionCosts;
            
        }
    }
}
