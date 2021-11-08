using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(int userId, int medicineId, int quantity)
        {
            return new Cart
            {
                user_id = userId,
                medicine_id = medicineId,
                quantity = quantity
            };
        }
    }
}