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
    public partial class INSERT_MEDICINE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CEK SESSION APAKAH MASIH ADA ATAU SUDAH EXPIRED
            if (Session["USER"] == null)
            {
                Response.Redirect("LOGIN.aspx");
            }

            User u = (User)Session["USER"];
            if (u.role_id == 2)
            {
                Response.Redirect("HOME.aspx");
            }
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            string medicineName = medicineNameTxt.Text;
            string medicineDesc = medicineDescTxt.Text;

            string stock = medicineStockTxt.Text;
            string price = medicinePriceTxt.Text;

            int medicineStock = -1;
            try
            {
                medicineStock = Convert.ToInt32(stock);
            }
            catch (Exception err)
            {
                messageLbl.Text = "stock must be numeric, more than 0 and can't be empty";
            }

            int medicinePrice = -1;
            try
            {
                medicinePrice = Convert.ToInt32(price);
            }
            catch (Exception err)
            {
                messageLbl.Text = "price must be numeric, more than 0 and can't be empty";
            }

            messageLbl.Text = MedicineController.InsertMedicine(medicineName, medicineDesc, medicineStock, medicinePrice);
        }
    }
}