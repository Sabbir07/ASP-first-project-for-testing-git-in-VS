using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        //Actually did nothing in this class
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //all changes and coding done in this class only
        protected void okButton_Click(object sender, EventArgs e)
        {
            string firstName1 = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            string result = "Hello " + firstName1 + " " + lastName;

            resultLabel.Text = result;
        }
    }
}