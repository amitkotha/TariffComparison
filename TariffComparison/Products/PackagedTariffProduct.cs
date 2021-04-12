using System;
using System.Collections.Generic;
using System.Text;

namespace TariffComparison.Products
{
  public  class PackagedTariffProduct:IProduct
    {
        public string Name
        {
            get { return "Packaged Tariff"; }
        }
        public double CalculationModel(int consumption)
        {
            double fixedCost = 800;
            if (consumption < 4000)
            {
                return fixedCost;
            }
            else
            {
                int additionalConsumption = consumption - 4000;
                double additionalCost = additionalConsumption * 0.3;
                return fixedCost + additionalCost;

            }

        }
    }
}
