using CalculatorTest.WebServices;

namespace CalculatorTest.Services
{
    public class CalculatorFascade : ICalculatorFascade
    {
        public int Add(int start, int amount)
        {
            MathService mathService = new MathService();
            return mathService.Add(start, amount);
        }

        public int Subtract(int start, int amount)
        {
            MathService mathService = new MathService();
            return mathService.Subtract(start, amount);
        }
    }
}