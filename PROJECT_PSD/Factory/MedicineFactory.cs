using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Factory
{
    public class MedicineFactory
    {
        public static Medicine CreateMedicine(string medicineName, string medicineDesc, int stock, int price)
        {
            return new Medicine
            {
                medicine_name = medicineName,
                medicine_desc = medicineDesc,
                medicine_stock = stock,
                medicine_price = price
            };
        }
    }
}