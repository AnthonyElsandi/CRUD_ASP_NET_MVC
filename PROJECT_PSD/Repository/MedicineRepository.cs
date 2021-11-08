using PROJECT_PSD.Factory;
using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Repository
{
    public class MedicineRepository
    {
        private static DatabaseCentuDYEntities db = DatabaseSingleton.getInstance();

        public static List<Medicine> GetAllMedicine()
        {
            return db.Medicines.ToList();
        }

        public static Medicine GetMedicineById(int id)
        {
            Medicine m = db.Medicines.Find(id);
            return m;
        }

        public static int DeleteMedicine(int medicineId)
        {
            Medicine m = db.Medicines.Find(medicineId);
            db.Medicines.Remove(m);
            return db.SaveChanges();
        }

        public static List<Medicine> SearchMedicineByName(string medicineName)
        {
            return (from x in db.Medicines where x.medicine_name.Contains(medicineName) select x).ToList();
        }

        public static int InsertMedicine(string medicineName, string medicineDesc, int stock, int price)
        {
            Medicine m = MedicineFactory.CreateMedicine(medicineName, medicineDesc, stock, price);
            db.Medicines.Add(m);
            return db.SaveChanges();
        }

        public static Medicine UpdateMedicine(int medicineId, string medicineName, string medicineDesc, int stock, int price)
        {
            Medicine m = db.Medicines.Find(medicineId);

            if (m != null)
            {
                m.medicine_name = medicineName;
                m.medicine_desc = medicineDesc;
                m.medicine_stock = stock;
                m.medicine_price = price;
            }
            return m;
        }
    }
}