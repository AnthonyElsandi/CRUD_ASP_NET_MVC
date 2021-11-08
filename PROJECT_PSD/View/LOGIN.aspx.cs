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
    public partial class LOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //CEK SESSION & COOKIES APAKAH MASIH ADA ATAU SUDAH EXPIRED
                if (Session["USER"] != null)
                {
                    Response.Redirect("HOME.aspx");
                }

                if (Request.Cookies["USERNAME"] != null && Request.Cookies["PASSWORD"] != null)
                {
                    string username = Request.Cookies["USERNAME"].Value;
                    string password = Request.Cookies["PASSWORD"].Value;
                    usernameTxt.Text = username;
                    passwordTxt.Text = password;
                }
            }

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            var response = AuthController.Login(username, password);
            if (response is User)
            {
                User u = response;
                Session["USER"] = u;

                if (rememberMeChk.Checked)
                {
                    Response.Cookies["USERNAME"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["PASSWORD"].Expires = DateTime.Now.AddDays(-1);
                    HttpCookie cookieUsername = new HttpCookie("USERNAME");
                    HttpCookie cookiePassword = new HttpCookie("PASSWORD");
                    cookieUsername.Value = u.user_username;
                    cookiePassword.Value = u.user_password;
                    cookieUsername.Expires = DateTime.Now.AddDays(1);
                    cookiePassword.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookieUsername);
                    Response.Cookies.Add(cookiePassword);
                }

                Response.Redirect("HOME.aspx");
            }
            else if (response is string)
            {
                messageLbl.Text = response;
            }
        }
    }
}