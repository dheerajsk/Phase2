using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForms
{
    public partial class SignupForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCountry.Items.Add(new ListItem("India"));
            ddlCountry.Items.Add(new ListItem("USA"));
            ddlCountry.Items.Add(new ListItem("Australia"));
            ddlCountry.Items.Add(new ListItem("UK"));
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string content = string.Empty;
            content += "FirstName: " + txtbFName.Text;
            content += "Lastname: " + txtbLastName.Text;
            content += "Country: " + ddlCountry.SelectedValue;
            content += "Gender: " + (rbMale.Checked == true ? "Male" : "Female");

            lblData.InnerText = content;

        }
    }
}