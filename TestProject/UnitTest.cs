using API_REST.Services;
using API_REST.Utilidades;
using NUnit.Framework;
using System.Collections;

namespace TestProject
{
    public class Tests
    {
        private RequestService requestService;
        [SetUp]
        public void Setup()
        {
            requestService = new RequestService();
        }

        [Test]
        public void CalculationPrimeNumbers_IsNotNull_ShouldPass()
        {
            var result = requestService.CalculationPrimeNumbers(2, 10, "Reiphy");
            Assert.IsNotNull(result);
        }

        [Test]
        public void CalculationPrimeNumbers_IsNotNull_ShouldFail()
        {
            var result = requestService.CalculationPrimeNumbers(2, 10, "Reiphy");
            Assert.AreEqual(10, result.Count);
        }

        [Test]
        public void CalculationPrimeNumbers_ShouldPass()
        {
            var result = requestService.CalculationPrimeNumbers(2, 10, "Reiphy");
            Assert.That(result[0] == 2);
        }

        [TestCase(2)]
        [TestCase(11)]
        public void IsPrime_WhenNumberIsPrime_ReturnTrue(int number)
        {
            var result = IsPrime.IsPrimeMethodo(number);
            Assert.IsTrue(result);
        }
        
        [Test]
        public void IsPrime_WhenNumberIsNotPrime_ReturnFalse()
        {
            var result = IsPrime.IsPrimeMethodo(0);
            Assert.IsFalse(result);
        }

    }
}