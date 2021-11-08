using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Factory
{
    public class HeaderTransactionFactory
    {
        public static HeaderTransaction CreateHeaderTransaction(int userId, string transactionDate)
        {
            return new HeaderTransaction
            {
                user_id = userId,
                transaction_date = transactionDate
            };
        }
    }
}