using System;

namespace CalculatorTest.Services
{
    public interface ICalculatorFascade
    {
        int Add(int start, int amount);

        int Subtract(int start, int amount);
    }
}