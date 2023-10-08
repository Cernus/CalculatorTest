using CalculatorTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorTest
{
    public partial class _Default : Page
    {
        ICalculatorFascade CalculatorFascade;

        protected void Page_Load(object sender, EventArgs e)
        {
            CalculatorFascade = new CalculatorFascade();
        }

        protected void Modal_Click(object sender, EventArgs e)
        {
            ShowModal();
        }

        protected void Modal_Add(object sender, EventArgs e)
        {
            //int start = Int32.Parse(txtstart.Text);
            //int amount = Int32.Parse(txtamount.Text);

            //int value = CalculatorFascade.Add(start, amount);

            ShowModal();
        }

        protected void Modal_Subtract(object sender, EventArgs e)
        {
            string test = "subtract";

            ShowModal();
        }

        private void ShowModal()
        {
            string script = "$('#mymodal').modal('show')";
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", script, true);
        }
    }
}