using PROJECT_PSD.Controller;
using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_PSD.View
{
    public partial class PROFILE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CEK SESSION APAKAH MASIH ADA ATAU SUDAH EXPIRED
            User u;
            if (Session["USER"] == null)
            {
                Response.Redirect("LOGIN.aspx");
            }

            //FETCH PROFILE DATA
            u = (User)Session["USER"];
            usernameValue.Text = u.user_username;
            nameValue.Text = u.user_name;
            genderValue.Text = u.user_gender;
            phoneNumberValue.Text = u.user_phone_number;
            addressValue.Text = u.user_address;
        }
        protected void updateProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UPDATE_PROFILE.aspx");
        }

        protected void changePasswordBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CHANGE_PASSWORD.aspx");
        }
    }
}