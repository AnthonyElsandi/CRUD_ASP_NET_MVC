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
    public partial class VIEW_USERS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
            {
                Response.Redirect("LOGIN.aspx");
            }

            User u = (User)Session["USER"];
            if (u.role_id == 2)
            {
                Response.Redirect("HOME.aspx");
            }

            gvUser.DataSource = UserController.GetAllMember();
            gvUser.DataBind();
        }

        protected void gvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = gvUser.Rows[e.RowIndex].Cells[1].Text;

            int userId = -1;

            try
            {
                userId = Convert.ToInt32(id);
            }
            catch (Exception err)
            {
                messageLbl.Text = "User not found";
            }

            messageLbl.Text = UserController.DeleteUserById(userId);
            List<VIEW_USERS_Model> source = UserController.GetAllMember();
            gvUser.DataSource = source;
            gvUser.DataBind();
        }
    }
}