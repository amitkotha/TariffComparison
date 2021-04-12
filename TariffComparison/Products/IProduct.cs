

namespace TariffComparison.Products
{
   public interface IProduct
    {
        double CalculationModel(int consumption);
        
        string Name { get; }
    }
}
