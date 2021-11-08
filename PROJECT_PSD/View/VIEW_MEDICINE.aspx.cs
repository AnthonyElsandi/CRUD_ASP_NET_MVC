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
    public partial class VIEW_MEDICINE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CEK SESSION APAKAH MASIH ADA ATAU SUDAH EXPIRED
            if (Session["USER"] == null)
            {
                Response.Redirect("LOGIN.aspx");
            }

            User u = (User)Session["USER"];
            if (u.role_id == 1)
            {
                gvMember.Attributes.Add("hidden", "");
                gvAdmin.Attributes.Remove("hidden");
                List<Medicine> dataSource = MedicineController.GetAllMedicine();
                gvAdmin.DataSource = dataSource;
                gvAdmin.DataBind();
            }
            else if (u.role_id == 2)
            {
                insertMedicine.Visible = false;
                gvAdmin.Attributes.Add("hidden", "");
                gvMember.Attributes.Remove("hidden");
                List<Medicine> dataSource = MedicineController.GetAllMedicine();
                gvMember.DataSource = dataSource;
                gvMember.DataBind();
            }
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            User u = (User)Session["USER"];
            string search = searchTxt.Text;
            List<Medicine> dataSource = MedicineController.SearchMedicine(search);
            if (u.role_id == 1)
            {
                gvAdmin.DataSource = dataSource;
                gvAdmin.DataBind();
            }
            else if (u.role_id == 2)
            {
                gvMember.DataSource = dataSource;
                gvMember.DataBind();
            }

        }
        protected void gvMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            string medicineId = gvMember.SelectedRow.Cells[1].Text;
            int id = Convert.ToInt32(medicineId);
            Response.Redirect("ADD_TO_CART.aspx?id=" + id);
        }

        protected void gvAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string medicineId = gvAdmin.Rows[e.RowIndex].Cells[2].Text;
            int id = Convert.ToInt32(medicineId);
            messageLbl.Text = MedicineController.DeleteMedicine(id);
            List<Medicine> source = MedicineController.GetAllMedicine();
            gvAdmin.DataSource = source;
            gvAdmin.DataBind();
        }

        protected void gvAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string medicineId = gvAdmin.SelectedRow.Cells[2].Text;
            int id = Convert.ToInt32(medicineId);
            Response.Redirect("UPDATE_MEDICINE.aspx?id=" + id);
        }

        protected void insertMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("INSERT_MEDICINE.aspx");
        }
    }
}