using TariffComparison.Products;

namespace TariffComparison
{
    public class Tariff
    {
        public IProduct product;
        public int consumption;
        public Tariff(IProduct product,int consumption)
        {
            this.product = product;
            this.consumption = consumption;
        }

        public string TariffName
        {
            get
            {
                return product.Name;
            }
        }

        public double AnnualCost
        {
            get
            {
                return product.CalculationModel(consumption);
            }
        }

    }
}
