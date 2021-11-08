using PROJECT_PSD.Model;
using PROJECT_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Handler
{
    public class CartHandler
    {
        public static List<Cart> GetCartsByUserId(int id)
        {
            return CartRepository.GetCartsByUserId(id);
        }

        public static int UpdateCart(int userId, int medicineId, int quantity)
        {
            return CartRepository.UpdateCart(userId, medicineId, quantity);
        }

        public static int AddItemToCart(int userId, int medicineId, int quantity)
        {
            return CartRepository.AddItemToCart(userId, medicineId, quantity);
        }

        public static Cart GetCartsByUserIdAndMedicineId(int userId, int medicineId)
        {
            return CartRepository.GetCartsByUserIdAndMedicineId(userId, medicineId);
        }

        public static List<VIEW_CART_MODEL> GetViewCartModels(int id)
        {
            return CartRepository.GetViewCartsByUserId(id);
        }

        public static int DeleteCartByMedicineId(int medicineId)
        {
            return CartRepository.DeleteCartByMedicineId(medicineId);
        }
    }
}