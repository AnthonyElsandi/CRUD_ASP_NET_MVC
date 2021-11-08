using PROJECT_PSD.Controller;
using PROJECT_PSD.Handler;
using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_PSD.View
{
    public partial class VIEW_CART : System.Web.UI.Page
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

            if (!IsPostBack)
            {
                int id = -1;

                try
                {
                    id = Convert.ToInt32(u.user_id);
                }
                catch (Exception err)
                {
                    messageLbl.Text = "Cart not found";
                }

                List<VIEW_CART_MODEL> source = CartController.GetViewCartModels(id);

                int grandTotal = 0;

                for (int i = 0; i < source.Count; i++)
                {
                    grandTotal += source[i].sub_total;
                }

                gvCart.DataSource = source;
                gvCart.DataBind();
                grandTotalTxt.Text = grandTotal.ToString();
            }
        }

        protected void gvCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = gvCart.Rows[e.RowIndex].Cells[1].Text;
            string stock = gvCart.Rows[e.RowIndex].Cells[3].Text;

            int medicineId = -1;
            try
            {
                medicineId = Convert.ToInt32(id);
            }
            catch (Exception err)
            {
                messageLbl.Text = "Item not found";
            }

            int medicineStock = -1;
            try
            {
                medicineStock = Convert.ToInt32(stock);
            }
            catch (Exception err)
            {
                messageLbl.Text = err.Message;
            }

            User u = (User)Session["USER"];

            messageLbl.Text = CartController.DeleteCartByMedicineId(u.user_id, medicineId);

            List<VIEW_CART_MODEL> source = CartController.GetViewCartModels(u.user_id);

            int grandTotal = 0;

            for (int i = 0; i < source.Count; i++)
            {
                grandTotal += source[i].sub_total;
            }

            gvCart.DataSource = source;
            gvCart.DataBind();
            grandTotalTxt.Text = grandTotal.ToString();
        }

        protected void checkOut_Click(object sender, EventArgs e)
        {
            User u = (User)Session["USER"];

            if (HeaderTransactionHandler.InsertHeaderTransaction(u.user_id) != 0)
            {
                List<Cart> carts = CartHandler.GetCartsByUserId(u.user_id);
                //HeaderTransaction ht = HeaderTransactionHandler.GetHeaderTransactionByTransactionId()
                //foreach (Cart c in carts)
                //{
                //    DetailTransactionHandler.InsertDetailTransaction()
                //}
            }
        }
    }
}