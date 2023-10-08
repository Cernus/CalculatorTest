using CalculatorApplication.WebServices;

namespace CalculatorApplication.Services
{
    // The Fascade pattern ensures that the business layer remains agnostic of the means to connect to the web service
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