using PROJECT_PSD.Handler;
using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Controller
{
    public class CartController
    {
        public static List<Cart> GetCartsByUserId(int id)
        {
            return CartHandler.GetCartsByUserId(id);
        }

        public static string AddItemToCart(int userId, int medicineId, int quantity)
        {

            Medicine m = MedicineHandler.GetMedicineById(medicineId);
            int stock = m.medicine_stock;
            if (quantity > stock) return "Quantity more than the available stock";
            if (quantity <= 0) return "Quantity must be more than 0";

            Cart c = CartHandler.GetCartsByUserIdAndMedicineId(userId, medicineId);
            m.medicine_stock = m.medicine_stock + ((-1) * quantity);

            if (c != null)
            {
                quantity += c.quantity;
                int u = CartHandler.UpdateCart(userId, medicineId, quantity);
            }
            else
            {
                if (CartHandler.AddItemToCart(userId, medicineId, quantity) != 0)
                {
                    return "Add to cart success";
                }
            }
            
            Medicine response = MedicineHandler.UpdateMedicine(m.medicine_id, m.medicine_name, m.medicine_desc, m.medicine_stock, m.medicine_price);

            if (response != null) return "Add to cart success";
            return "Add to cart failed";
        }

        public static List<VIEW_CART_MODEL> GetViewCartModels(int id)
        {
            return CartHandler.GetViewCartModels(id);
        }

        public static string DeleteCartByMedicineId(int userId, int medicineId)
        {
            Cart c = CartHandler.GetCartsByUserIdAndMedicineId(userId, medicineId);

            Medicine m = MedicineHandler.GetMedicineById(medicineId);

            m.medicine_stock = m.medicine_stock + c.quantity;

            Medicine response = MedicineHandler.UpdateMedicine(m.medicine_id, m.medicine_name, m.medicine_desc, m.medicine_stock, m.medicine_price);

            if (CartHandler.DeleteCartByMedicineId(medicineId) != 0 && response != null)
            {
                return "Delete Sucess";
            }
            return "Delete Failed";
        }

        public static string CheckOutCart()
        {
            return "";
        }
    }
}