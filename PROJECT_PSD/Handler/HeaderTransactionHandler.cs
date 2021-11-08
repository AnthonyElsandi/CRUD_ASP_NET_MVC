using PROJECT_PSD.Model;
using PROJECT_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Handler
{
    public class HeaderTransactionHandler
    {
        public static HeaderTransaction GetHeaderTransactionByTransactionId(int transactionId)
        {
            return HeaderTransactionRepository.GetHeaderTransactionByTransactionId(transactionId);
        }

        public static int InsertHeaderTransaction(int userId)
        {
            return HeaderTransactionRepository.InsertHeaderTransaction(userId);
        }
    }
}