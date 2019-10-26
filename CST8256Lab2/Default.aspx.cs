using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8256Lab2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {


            string text_Number = txtnumber.Text;
            string text_Name = txtname.Text;

           
            Course course_name = new Course(text_Number, text_Name);
            Session["course"] = course_name;
            Response.Redirect("StudentRecords.aspx");
        }
    }
}