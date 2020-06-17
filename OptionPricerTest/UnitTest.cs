using NUnit.Framework;
using OptionPricer;

namespace OptionPricerTest
{
    /// <summary>
    /// The class Tests contains a test that check if the price method runs OK or not
    /// </summary>
    //[TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            //Triple A == Arrange, Act, Assert
            //Arrange
            int iPrecision = 4;
            double dStockPrice = 50;
            double dStrikePrice = 55;
            double dTimeToMaturity = 1;
            double dStdDerivUnderlying = 0.2;
            double dRiskFreeInterestRate = 0.09;
            Constants.EuroOptionType euroOptionType = Constants.EuroOptionType.Call;

            //Act
            FinancialProduct product = new EuropeanOption(dStockPrice, dStrikePrice, dTimeToMaturity, dStdDerivUnderlying, dRiskFreeInterestRate, euroOptionType);
            var pricer = new EuropeanOptionPricer(iPrecision);
            double dResultPricing = pricer.Price(product);

            //Assert
            Assert.AreEqual(dResultPricing.ToString(), "3.8617");
        }
    }
}