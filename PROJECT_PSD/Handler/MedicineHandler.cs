using PROJECT_PSD.Model;
using PROJECT_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Handler
{
    public class MedicineHandler
    {
        public static List<Medicine> GetAllMedicine()
        {
            return MedicineRepository.GetAllMedicine();
        }

        public static int InsertMedicine(string medicineName, string medicineDesc, int stock, int price)
        {
            return MedicineRepository.InsertMedicine(medicineName, medicineDesc, stock, price);
        }

        public static Medicine UpdateMedicine(int medicineId, string medicineName, string medicineDesc, int stock, int price)
        {
            return MedicineRepository.UpdateMedicine(medicineId, medicineName, medicineDesc, stock, price);
        }
        public static Medicine GetMedicineById(int id)
        {
            return MedicineRepository.GetMedicineById(id);
        }

        public static List<Medicine> SearchMedicine(string search)
        {
            return MedicineRepository.SearchMedicineByName(search);
        }

        public static int DeleteMedicine(int medicineId)
        {
            CartRepository.DeleteCartByMedicineId(medicineId);
            List<int> headerTransactionIds = DetailTransactionRepository.GetHeaderTransactionIdsByMedicineId(medicineId);
            DetailTransactionRepository.DeleteDetailTransactionByMedicineId(medicineId);
            if (headerTransactionIds == null)
            {
                HeaderTransactionRepository.DeleteHeaderTransactions(headerTransactionIds);
            }
            return MedicineRepository.DeleteMedicine(medicineId);
        }
    }
}