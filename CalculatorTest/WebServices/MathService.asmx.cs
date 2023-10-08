using System.Web.Services;
using CalculatorTest.Data;

namespace CalculatorTest.WebServices
{
    /// <summary>
    /// Summary description for MathService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int start, int amount)
        {
            SimpleCalculator calculator = new SimpleCalculator();
            return calculator.Add(start, amount);
        }

        [WebMethod]
        public int Subtract(int start, int amount)
        {
            SimpleCalculator calculator = new SimpleCalculator();
            return calculator.Subtract(start, amount);
        }
    }
}
