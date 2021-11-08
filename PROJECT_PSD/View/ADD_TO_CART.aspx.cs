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
    public partial class ADD_TO_CART : System.Web.UI.Page
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

                Medicine m = MedicineController.GetMedicineById(id);
                medicineNameTxt.Text = m.medicine_name;
                medicineDescTxt.Text = m.medicine_desc;
                medicineStockTxt.Text = m.medicine_stock.ToString();
                medicinePriceTxt.Text = m.medicine_price.ToString();
            }
        }

        protected void addToCart_Click(object sender, EventArgs e)
        {
            User u = (User)Session["USER"];

            string idFromParameter = Request.QueryString["id"];

            int medicineId = -1;

            try
            {
                medicineId = Convert.ToInt32(idFromParameter);
            }
            catch (Exception err)
            {
                messageLbl.Text = "Medicine not found";
            }
            
            string quantity = inputQuantityTxt.Text;

            int medicineQuantity = -1;
            try
            {
                medicineQuantity = Convert.ToInt32(quantity);
            }
            catch (Exception err)
            {
                messageLbl.Text = "Medicine not found";
            }

            string message = CartController.AddItemToCart(u.user_id, medicineId, medicineQuantity);
            messageLbl.Text = message;

            if (message == "Add to cart success") Response.Redirect("VIEW_CART.aspx");

        }
    }
}