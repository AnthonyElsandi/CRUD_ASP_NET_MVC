using PROJECT_PSD.Handler;
using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Controller
{
    public class MedicineController
    {
        public static dynamic GetMedicineById(int id)
        {
            Medicine m = MedicineHandler.GetMedicineById(id);
            if (m != null) return m;
            return "Medicine not found";
        }

        public static List<Medicine> GetAllMedicine()
        {
            return MedicineHandler.GetAllMedicine();
        }

        public static List<Medicine> SearchMedicine(string search)
        {
            return MedicineHandler.SearchMedicine(search);
        }

        public static string DeleteMedicine(int medicineId)
        {
            if (MedicineHandler.DeleteMedicine(medicineId) != 0) return "Delete Success";

            return "Delete Failed";
        }

        public static string UpdateMedicine(int medicineId, string medicineName, string medicineDesc, int medicineStock, int medicinePrice)
        {

            if (medicineName == "") return "Medicine name cannot be empty";

            if (medicineDesc.Length < 11) return "Medicine desc cannot be empty and must be longer than 10 characters";

            if (medicineStock < 1) return "stock must be numeric, more than 0 and can't be empty";

            if (medicinePrice < 0) return "price must be numeric, more than 0 and can't be empty";

            if (MedicineHandler.UpdateMedicine(medicineId, medicineName, medicineDesc, medicineStock, medicinePrice) is Medicine) return "Update Medicine Success";

            return "Update Medicine Failed";
        }

        public static string InsertMedicine(string medicineName, string medicineDesc, int medicineStock, int medicinePrice)
        {
            if (medicineName == "") return "Medicine name cannot be empty";

            if (medicineDesc.Length < 11)
            {
                return "Medicine desc cannot be empty and must be longer than 10 characters";
            }

            if (medicineStock < 1) return "stock must be numeric, more than 0 and can't be empty";

            if (medicinePrice < 1) return "price must be numeric, more than 0 and can't be empty";

            if (MedicineHandler.InsertMedicine(medicineName, medicineDesc, medicineStock, medicinePrice) != 0) return "Insert Medicine Success";

            return "Insert Medicine Failed";
        }
    }
}