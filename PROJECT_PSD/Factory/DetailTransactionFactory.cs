using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Factory
{
    public class DetailTransactionFactory
    {
        public static DetailTransaction CreateDetailTransaction(int transactionId, int medcineId, int medicineQuantity)
        {
            return new DetailTransaction
            {
                transaction_id = transactionId,
                medicine_id = medcineId,
                quantity = medicineQuantity
            };
        }
    }
}