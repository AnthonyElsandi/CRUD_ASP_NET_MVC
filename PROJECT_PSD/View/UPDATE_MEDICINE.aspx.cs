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
    public partial class UPDATE_MEDICINE : System.Web.UI.Page
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
            string idFromParameter = Request.QueryString["id"];

            if (!IsPostBack)
            {
                int id = -1;
                try
                {
                    id = Convert.ToInt32(idFromParameter);
                }
                catch (Exception err)
                {
                    messageLbl.Text = "Medicine not found";
                }

                var response = MedicineController.GetMedicineById(id);

                if (response is Medicine)
                {
                    medicineNameTxt.Text = response.medicine_name;
                    medicineDescTxt.Text = response.medicine_desc;
                    medicineStockTxt.Text = response.medicine_stock.ToString();
                    medicinePriceTxt.Text = response.medicine_price.ToString();
                }
                else
                {
                    messageLbl.Text = response;
                }
                
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string medicineName = medicineNameTxt.Text;
            string medicineDesc = medicineDescTxt.Text;
            string stock = medicineStockTxt.Text;
            string price = medicinePriceTxt.Text;
            string idFromParameter = Request.QueryString["id"];

            int id = -1;
            try
            {
                id = Convert.ToInt32(idFromParameter);
            }
            catch (Exception err)
            {
                messageLbl.Text = "Medicine not found";
            }

            int medicineStock = -1;
            try
            {
                medicineStock = Convert.ToInt32(stock);
            }
            catch (Exception err)
            {
                messageLbl.Text = "Stock must be numeric, more than 0 and can't be empty";
            }

            int medicinePrice= -1;
            try
            {
                medicinePrice = Convert.ToInt32(price);
            }
            catch (Exception err)
            {
                messageLbl.Text = "Price must be numeric, more than 0 and can't be empty";
            }

            messageLbl.Text = MedicineController.UpdateMedicine(id, medicineName, medicineDesc, medicineStock, medicinePrice);
        }
    }
}