using NUnit.Framework;
using TariffComparison.Products;

namespace TariffComparison.Test
{
    public class BasicTariffProductTest
    {
        IProduct productService;
        [SetUp]
        public void Setup()
        {
            productService = new BasicTariffProduct();
        }

        public  double CalculateAnnualCost(int consumption) => productService.CalculationModel(consumption);
        [Test]
        public void Test_Expected_Correct_AnnualCost()
        {
            Assert.AreEqual(830, CalculateAnnualCost(3500));
            Assert.AreEqual(1050, CalculateAnnualCost(4500));
            Assert.AreEqual(1380, CalculateAnnualCost(6000));
            Assert.AreEqual(60, CalculateAnnualCost(0));
        }
    }
}