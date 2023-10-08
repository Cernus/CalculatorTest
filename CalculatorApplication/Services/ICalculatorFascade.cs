using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace CalculatorApplication.Services
{
    public interface ICalculatorFascade
    {
        int Add(int start, int amount);

        int Subtract(int start, int amount);
    }
}