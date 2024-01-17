namespace MathService;

public class FactorialService
{
    public int CalculateFactorial(int number = 5)
        {
            if (number < 0)
            {
                throw new ArgumentException("Input must be a non-negative integer.", nameof(number));
            }

            if (number == 0 || number == 1)
            {
                return 1;
            }

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
}

