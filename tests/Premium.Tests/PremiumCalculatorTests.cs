using Premium.Web.Services;
using Xunit;

namespace Premium.Tests
{
    public class PremiumCalculatorTests
    {
        [Fact]
        public void CalculatePremium_WithValidInputs_ReturnsExpected()
        {
            //Arrange
            var factorProvider = new OccupationFactorProvider();
            var service = new PremiumCalculatorService(factorProvider);

            //ACT
            int age = 30;
            decimal death = 500000M; // 500k
            string occupation = "Doctor"; // Professional 1.5

            // Expected = (500000 * 1.5 * 30) / 1000 * 12 = 270000
            var result = service.CalculatePremium(age, death, occupation);
            //Assert
            Assert.Equal(270000M, result);
        }

        [Fact]
        public void CalculatePremium_InvalidOccupation_ReturnsZero()
        {
            //Arrange
            var factorProvider = new OccupationFactorProvider();
            var service = new PremiumCalculatorService(factorProvider);
            //ACT
            var result = service.CalculatePremium(30, 100000M, "UnknownOccupation");
            //Assert
            Assert.Equal(0M, result);
        }
    }
}
