using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TariffComparison.Products;

namespace TariffComparison.Test
{
  public  class PackagedTariffProductTest
    {
        IProduct productService;
        [SetUp]
        public void Setup()
        {
            productService = new PackagedTariffProduct();
        }

        public double CalculateAnnualCost(int consumption) => productService.CalculationModel(consumption);
        [Test]
        public void Test_Expected_Correct_AnnualCost()
        {
            Assert.AreEqual(800, CalculateAnnualCost(3500));
            Assert.AreEqual(950, CalculateAnnualCost(4500));
            Assert.AreEqual(1400, CalculateAnnualCost(6000));
            Assert.AreEqual(800, CalculateAnnualCost(0));
        }
    }
}
