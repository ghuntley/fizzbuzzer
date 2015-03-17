using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzzer.Tests
{
    public class FizzBuzzerTests
    {
        [Test]
        public void FizzBuzzMinValueShouldDefaultToOne()
        {
            var bottle = new FizzBuzzer();
            bottle.MinValue.Should().Be(1);
        }

        [Test]
        public void ShakeItShouldYieldCorrectResults()
        {
            var bottle = new FizzBuzzer();
            var results = bottle.ShakeIt().ToList();

            results.Count.Should().Be(100);
            results[0].Should().Be("1");
            results[2].Should().Be("Fizz");
            results[4].Should().Be("Buzz");
            results[14].Should().Be("FizzBuzz");
        }

        [Test]
        public void FizzBuzzMaxValueShouldDefaultToOneHundred()
        {
            var bottle = new FizzBuzzer();
            bottle.MaxValue.Should().Be(100);
        }

        [Test]
        public void DivisableByFifteenShouldBeFizzBuzz()
        {
            var bottle = new FizzBuzzer();
            bottle.FizzOrBuzz(15).Should().Be("FizzBuzz");
        }

        [Test]
        public void DivisableByThreeShouldBeFizz()
        {
            var bottle = new FizzBuzzer();
            bottle.FizzOrBuzz(3).Should().Be("Fizz");
            bottle.FizzOrBuzz(6).Should().Be("Fizz");
            bottle.FizzOrBuzz(9).Should().Be("Fizz");
            bottle.FizzOrBuzz(12).Should().Be("Fizz");
        }

        [Test]
        public void DivisableByFiveShouldBeBuzz()
        {
            var bottle = new FizzBuzzer();
            bottle.FizzOrBuzz(5).Should().Be("Buzz");
            bottle.FizzOrBuzz(10).Should().Be("Buzz");

            // 15 should be FizzBuzzer.
            bottle.FizzOrBuzz(15).Should().NotBe("Buzz");
        }

        [Test]
        public void NotDivisibleByFizzOrBuzzOrFizzBuzzShouldBe()
        {
            var bottle = new FizzBuzzer();
            bottle.FizzOrBuzz(1).Should().Be("1");
            bottle.FizzOrBuzz(2).Should().Be("2");
            bottle.FizzOrBuzz(4).Should().Be("4");
            bottle.FizzOrBuzz(7).Should().Be("7");
            bottle.FizzOrBuzz(8).Should().Be("8");
            bottle.FizzOrBuzz(11).Should().Be("11");
            bottle.FizzOrBuzz(14).Should().Be("14");
            bottle.FizzOrBuzz(16).Should().Be("16");
        }
    }
}