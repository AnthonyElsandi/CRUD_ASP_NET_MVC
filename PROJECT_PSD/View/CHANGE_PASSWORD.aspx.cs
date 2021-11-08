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
    public partial class CHANGE_PASSWORD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CEK SESSION APAKAH MASIH ADA ATAU SUDAH EXPIRED
            User u;
            if (Session["USER"] == null)
            {
                Response.Redirect("LOGIN.aspx");
            }
        }

        protected void changePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPasswordTxt.Text;
            string newPassword = newPasswordTxt.Text;
            string confirmPassword = confirmPasswordTxt.Text;
            User u = (User)Session["USER"];
            string username = u.user_username;
            string message = UserController.ChangePassword(username, oldPassword, newPassword, confirmPassword);
            messageLbl.Text = message;

            //MENGGANTI COOKIE PASSWORD(JIKA ADA) DARI PASSWORD YANG LAMA MENJADI PASSWORD YANG BARU
            if (message == "Password berhasil di update")
            {
                string password = Request.Cookies["PASSWORD"].Value;
                if (password != null)
                {
                    Response.Cookies["PASSWORD"].Expires = DateTime.Now.AddDays(-1);
                    HttpCookie cookiePassword = new HttpCookie("PASSWORD");
                    cookiePassword.Value = u.user_password;
                }
            }
        }
    }
}