using CalculatorApplication.Services;
using Microsoft.Ajax.Utilities;
using System;
using System.Web.Services;
using System.Web.UI;

// The front-end was created using WebForms and .Net Framework. MVC could have also been used, although the application can be created cleanly without the use of models of viewmodels
namespace CalculatorApplication
{
    public partial class _Default : Page
    {
        ICalculatorFascade CalculatorFascade;

        protected void Page_Load(object sender, EventArgs e)
        {
            CalculatorFascade = new CalculatorFascade();
        }

        // Called from both "Open Model" button and "CLEAR" button in the modal
        protected void Modal_Clear(object sender, EventArgs e)
        {
            // Clear Content on Calculator Modal
            Clear();

            // Show Modal
            ShowModal();
        }

        // Called when the "Add" button is clicked
        protected void Modal_Add(object sender, EventArgs e)
        {
            int start = 0;
            if (!txtstart.Text.IsNullOrWhiteSpace()) { start = Int32.Parse(txtstart.Text); }

            int amount = 0;
            if (!txtamount.Text.IsNullOrWhiteSpace()) { amount = Int32.Parse(txtamount.Text); }

            int value = CalculatorFascade.Add(start, amount);

            txtResult.Text = value.ToString();

            ShowModal();
        }

        // Called when the "Subtract" button is clicked
        protected void Modal_Subtract(object sender, EventArgs e)
        {
            int start = 0;
            if (!txtstart.Text.IsNullOrWhiteSpace()) { start = Int32.Parse(txtstart.Text); }

            int amount = 0;
            if (!txtamount.Text.IsNullOrWhiteSpace()) { amount = Int32.Parse(txtamount.Text); }

            int value = CalculatorFascade.Subtract(start, amount);

            txtResult.Text = value.ToString();

            ShowModal();
        }
             
        // Clears all text boxes in the modal
        private void Clear()
        {
            // reset the text of all textboxes in the modal
            txtstart.Text = null;
            txtamount.Text = null;
            txtResult.Text = null;
        }

        // Displays the modal
        private void ShowModal()
        {
            string script = "$('#mymodal').modal('show')";
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", script, true);
        }
    }
}