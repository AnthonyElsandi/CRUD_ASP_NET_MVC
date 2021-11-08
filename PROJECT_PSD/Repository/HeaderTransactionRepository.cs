using PROJECT_PSD.Factory;
using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Repository
{
    public class HeaderTransactionRepository
    {
        private static DatabaseCentuDYEntities db = DatabaseSingleton.getInstance();

        public static int DeleteHeaderTransaction(int headerTransactionId)
        {
            HeaderTransaction ht = db.HeaderTransactions.Find(headerTransactionId);
            db.HeaderTransactions.Remove(ht);
            return db.SaveChanges();
        }

        public static HeaderTransaction GetHeaderTransactionByTransactionId(int transactionId)
        {
            HeaderTransaction ht = db.HeaderTransactions.Find(transactionId);
            return ht;
        }

        public static int InsertHeaderTransaction(int userId)
        {
            DateTime date = DateTime.Now;
            string dateNow = date.ToString();
            HeaderTransaction ht = HeaderTransactionFactory.CreateHeaderTransaction(userId, dateNow);
            db.HeaderTransactions.Add(ht);
            return db.SaveChanges();
        }

        public static int DeleteHeaderTransactions(List<int> ids)
        {
            List<HeaderTransaction> hts = null;
            foreach (int id in ids)
            {
                hts.Add(db.HeaderTransactions.Find(id));
            }
            db.HeaderTransactions.RemoveRange(hts);
            return db.SaveChanges();
        }

        public static int DeleteHeaderTransactionByUserId(int userId)
        {
            List<HeaderTransaction> headerTransactions = (from x in db.HeaderTransactions where x.user_id == userId select x).ToList();
            db.HeaderTransactions.RemoveRange(headerTransactions);
            return db.SaveChanges();
        }

        public static List<int> GetHeaderTransactionIdsByUserId(int userId)
        {
            return (from x in db.HeaderTransactions where x.user_id == userId select x.transaction_id).ToList();
        }
    }
}