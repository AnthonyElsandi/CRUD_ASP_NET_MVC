using PROJECT_PSD.Factory;
using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Repository
{
    public class CartRepository
    {
        private static DatabaseCentuDYEntities db = DatabaseSingleton.getInstance();

        public static int DeleteCartByMedicineId(int medicineId)
        {
            List<Cart> carts = (from x in db.Carts where x.medicine_id == medicineId select x).ToList();
            db.Carts.RemoveRange(carts);
            return db.SaveChanges();
        }

        public static void DeleteCartByUserId(int userId)
        {
            List<Cart> carts = (from x in db.Carts where x.user_id == userId select x).ToList();
            db.Carts.RemoveRange(carts);
            db.SaveChanges();
        }

        public static List<Cart> GetCartsByUserId(int id)
        {
            return (from x in db.Carts where x.user_id == id select x).ToList();
        }
        public static List<VIEW_CART_MODEL> GetViewCartsByUserId(int id)
        {
            return (from x in db.Carts
                    where x.user_id == id
                    select new VIEW_CART_MODEL()
                    {
                        medicine_id = x.medicine_id,
                        medicine_name = x.Medicine.medicine_name,
                        medicine_quantity = x.quantity,
                        sub_total = (x.quantity) * (x.Medicine.medicine_price)
                    }).ToList();
        }

        public static Cart GetCartsByUserIdAndMedicineId(int userId, int medicineId)
        {
            return (from x in db.Carts
                    where x.user_id == userId
                    where x.medicine_id == medicineId
                    select x).FirstOrDefault();
        }

        public static int UpdateCart(int userId, int medicineId, int quantity)
        {
            Cart c = CartRepository.GetCartsByUserIdAndMedicineId(userId, medicineId);

            if (c != null)
            {
                c.quantity = quantity;
            }
            return db.SaveChanges();
        }

        public static int AddItemToCart(int userId, int medicineId, int stock)
        {
            Cart c = CartFactory.CreateCart(userId, medicineId, stock);
            db.Carts.Add(c);
            return db.SaveChanges();
        }
    }
}