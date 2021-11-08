using PROJECT_PSD.Factory;
using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Repository
{
    public class DetailTransactionRepository
    {
        private static DatabaseCentuDYEntities db = DatabaseSingleton.getInstance();

        public static void DeleteDetailTransactions(List<int> headerTransactionIds)
        {
            List<DetailTransaction> dts = null;
            foreach (int id in headerTransactionIds)
            {
                dts.Add(db.DetailTransactions.Find(id));
            }

            db.DetailTransactions.RemoveRange(dts);
            db.SaveChanges();
        }

        public static void DeleteDetailTransactionByMedicineId(int medicineId)
        {
            List<DetailTransaction> detailTransactions = (from x in db.DetailTransactions where x.medicine_id == medicineId select x).ToList();
            db.DetailTransactions.RemoveRange(detailTransactions);
            db.SaveChanges();
        }

        public static int DeleteDetailTransactionByHeaderTransactionId(int headerTransactionId)
        {
            List<DetailTransaction> detailTransactions = (from x in db.DetailTransactions where x.transaction_id == headerTransactionId select x).ToList();
            db.DetailTransactions.RemoveRange(detailTransactions);
            return db.SaveChanges();
        }

        public static List<int> GetHeaderTransactionIdsByMedicineId(int medicineId)
        {
            List<int> ids = (from x in db.DetailTransactions where x.medicine_id == medicineId select x.transaction_id).ToList();
            return ids;
        }

        public static List<DetailTransaction> GetDetailTransactionByMedicineId(int medicineId)
        {
            List<DetailTransaction> detailTransactions = (from x in db.DetailTransactions where x.medicine_id == medicineId select x).ToList();
            return detailTransactions;
        }

        public static int InsertDetailTransaction(int transactionId, int medicineId, int medicineQuantity)
        {
            DetailTransaction dt = DetailTransactionFactory.CreateDetailTransaction(transactionId, medicineId, medicineQuantity);
            db.DetailTransactions.Add(dt);
            return db.SaveChanges();
        }
    }
}