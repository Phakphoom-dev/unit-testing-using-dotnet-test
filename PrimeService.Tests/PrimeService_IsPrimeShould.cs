using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Theory(DisplayName = "Test IsPrime for values less than 2")]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ShouldReturnFalse(int testValue)
        {
            bool result = _primeService.IsPrime(testValue);

            Assert.False(result, $"{testValue} should not be prime");
        }
    }
}