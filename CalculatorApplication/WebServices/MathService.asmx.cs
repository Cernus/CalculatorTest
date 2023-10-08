using CalculatorTest.Data;
using System.Web.Services;

namespace CalculatorApplication.WebServices
{
    /// <summary>
    /// Calls .Add() and .Subtract() in SimpleCalculator.cs in CalculatorTest.Data
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {

        // The Add Method refereneces SimpleCalculator.cs in the Class Library in order to calculate the sum
        [WebMethod]
        public int Add(int start, int amount)
        {
            SimpleCalculator calculator = new SimpleCalculator();
            return calculator.Add(start, amount);
        }

        // The Subtract Method refereneces SimpleCalculator.cs in the Class Library in order to calculate the sum
        [WebMethod]
        public int Subtract(int start, int amount)
        {
            SimpleCalculator calculator = new SimpleCalculator();
            return calculator.Subtract(start, amount);
        }
    }
}
