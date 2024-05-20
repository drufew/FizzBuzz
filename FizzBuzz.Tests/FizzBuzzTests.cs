namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;

        public FizzBuzzTests()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Fact]
        public void GivenValueIsDivisibleByThree_ShouldReturnFizz()
        {
            Assert.Equal("Fizz", _fizzBuzz.GetOutput(3));
        }

        [Fact]
        public void GivenValueIsDivisibleByFive_ShouldReturnBuzz()
        {
            Assert.Equal("Buzz", _fizzBuzz.GetOutput(5));
        }

        [Fact]
        public void GivenValueIsDivisibleByThreeAndFive_ShouldReturnFizzBuzz()
        {
            Assert.Equal("FizzBuzz", _fizzBuzz.GetOutput(15));
        }

        [Fact]
        public void GivenValueIsNotDivisibleByThreeOrFive_ShouldReturnValue()
        {
            Assert.Equal("2", _fizzBuzz.GetOutput(2));
        }
    }
}