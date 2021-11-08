using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Model
{
    public class VIEW_USERS_Model
    {
        public int user_id { get; set; }
        public string user_username { get; set; }
        public string user_name { get; set; }
        public string role_name { get; set; }
        public string user_gender { get; set; }
        public string user_phone_number { get; set; }
        public string user_address { get; set; }
    }
}