using PROJECT_PSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_PSD.View
{
    public partial class REGISTER : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string confirmPassword = confirmPasswordTxt.Text;
            string name = nameTxt.Text;
            string gender = dropDownListGender.SelectedValue;
            string phoneNumber = phoneNumberTxt.Text;
            string address = addressTxt.Text;

            string response = AuthController.Register(username, password, confirmPassword, name, gender, phoneNumber, address);
            messageLbl.Text = response;
        }
    }
}