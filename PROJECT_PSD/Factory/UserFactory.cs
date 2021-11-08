using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Factory
{
    public class UserFactory
    {
        public static User createUser(string username, string password, string name, string gender, string phoneNumber, string address)
        {
            return new User
            {
                role_id = 2,
                user_username = username,
                user_password = password,
                user_name = name,
                user_gender = gender,
                user_phone_number = phoneNumber,
                user_address = address
            };
        }
    }
}