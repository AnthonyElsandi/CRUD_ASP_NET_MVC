using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Model
{
    public class VIEW_CART_MODEL
    {
        public int medicine_id { get; set; }
        public string medicine_name { get; set; }
        public int medicine_quantity { get; set; }
        public int sub_total { get; set; }
    }
}