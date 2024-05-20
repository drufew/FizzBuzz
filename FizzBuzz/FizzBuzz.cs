namespace FizzBuzz
{
    public class FizzBuzz
    {
        private readonly List<IFizzBuzzCriteria> _fizzBuzzCriteria;

        public FizzBuzz()
        {
            _fizzBuzzCriteria = new List<IFizzBuzzCriteria>
            {
                new FizzBuzzCriteria(),
                new FizzCriteria(),
                new BuzzCriteria()
            };
        }

        public string GetOutput(int value)
        {
            foreach (var criteria in _fizzBuzzCriteria)
            {
                if (criteria.IsMatch(value))
                {
                    return criteria.GetOutput();
                }
            }
            return value.ToString();
        }

        public void Run(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(GetOutput(i));
            }
        }
    }

    public interface IFizzBuzzCriteria
    {
        bool IsMatch(int value);
        string GetOutput();
    }

    public class FizzBuzzCriteria : IFizzBuzzCriteria
    {
        public bool IsMatch(int value) => value % 3 == 0 && value % 5 == 0;
        public string GetOutput() => "FizzBuzz";
    }

    public class FizzCriteria : IFizzBuzzCriteria
    {
        public bool IsMatch(int value) => value % 3 == 0;
        public string GetOutput() => "Fizz";
    }

    public class BuzzCriteria : IFizzBuzzCriteria
    {
        public bool IsMatch(int value) => value % 5 == 0;
        public string GetOutput() => "Buzz";
    }
}
