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
    public partial class UPDATE_PROFILE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CEK SESSION & COOKIE APAKAH MASIH ADA ATAU SUDAH EXPIRED
            User u;
            if (Session["USER"] == null)
            {
                if (Request.Cookies["USERNAME"] == null || Request.Cookies["PASSWORD"] == null)
                {
                    Response.Redirect("LOGIN.aspx");
                }
                else
                {
                    string username = Request.Cookies["USERNAME"].Value;
                    string password = Request.Cookies["PASSWORD"].Value;
                    u = AuthController.Login(username, password);
                    Session["USER"] = u;
                }
            }

            if (!IsPostBack)
            {
                //FETCH DATA
                u = (User)Session["USER"];
                nameTxt.Text = u.user_name;
                dropDownListGender.Items.FindByValue(u.user_gender).Selected = true;
                phoneNumberTxt.Text = u.user_phone_number;
                addressTxt.Text = u.user_address;
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            User u = (User)Session["USER"];
            int userId = u.user_id;
            string name = nameTxt.Text;
            string gender = dropDownListGender.SelectedValue;
            string phoneNumber = phoneNumberTxt.Text;
            string address = addressTxt.Text;
            string message = UserController.UpdateProfile(userId, name, gender, phoneNumber, address);
            messageLbl.Text = message;
        }
    }
}