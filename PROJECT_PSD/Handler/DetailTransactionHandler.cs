using PROJECT_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Handler
{
    public class DetailTransactionHandler
    {
        public static int InsertDetailTransaction(int transactionId, int medicineId, int medicineQuantity)
        {
            return DetailTransactionRepository.InsertDetailTransaction(transactionId, medicineId, medicineQuantity);
        }
    }
}