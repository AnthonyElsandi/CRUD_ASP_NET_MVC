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
    public partial class HOME : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CEK SESSION APAKAH MASIH ADA ATAU SUDAH EXPIRED
            User u;
            if (Session["USER"] == null)
            {
                Response.Redirect("LOGIN.aspx");
            }

            u = (User)Session["USER"];
            usernameLbl.Text = "Hello " + u.user_username + ", Welcome to CentuDY";
            if (u.role_id == 1)
            {
                insertMedicineBtn.Attributes.Remove("hidden");
                viewUsersBtn.Attributes.Remove("hidden");
                viewTransactionReportBtn.Attributes.Remove("hidden");
            }
            else if (u.role_id == 2)
            {
                viewCartBtn.Attributes.Remove("hidden");
                viewTransactionHistoryBtn.Attributes.Remove("hidden");
            }
        }

        protected void viewProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PROFILE.aspx");
        }

        protected void viewTransactionHistoryBtn_Click(object sender, EventArgs e)
        {

        }

        protected void viewMedicinesBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("VIEW_MEDICINE.aspx");
        }

        protected void viewCartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("VIEW_CART.aspx");
        }

        protected void insertMedicineBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("INSERT_MEDICINE.aspx");
        }

        protected void viewUsersBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("VIEW_USERS.aspx");
        }

        protected void viewTransactionReportBtn_Click(object sender, EventArgs e)
        {

        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();

            Response.Redirect("LOGIN.aspx");
        }
    }
}