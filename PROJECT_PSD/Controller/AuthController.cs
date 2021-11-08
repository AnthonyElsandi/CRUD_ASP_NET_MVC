using PROJECT_PSD.Handler;
using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Controller
{
    public class AuthController
    {
        public static dynamic Login(string username, string password)
        {
            if (username == "") return "Username must be filled";
            if (password == "") return "Password must be filled";

            User u = UserHandler.GetUser(username, password);

            if (u == null) return "Wrong username or password";

            return u;
        }

        public static string Register(string username, string password, string confirmPassword, string name, string gender, string phoneNumber, string address)
        {
            if (username.Length < 3 || username == "") return "Username must be filled and atleast filled with 3 characters";

            if (UserHandler.GetUserByUsername(username) != null) return "Username already taken";

            if (password.Length < 8 || password == "") return "Password must be filled and atleast filled with 8 characters";

            if (confirmPassword != password) return "Password is not the same with confirmation password";

            if (name == "") return "Name must be filled";

            if (gender == "") return "Gender must be choosen";

            if (phoneNumber == "") return "Phone number must be numeric";
            
            if (!address.ToLower().Contains("street") || address == "") return "Address must contain the word 'street' and cannot be empty";

            if (UserHandler.InsertUser(username, password, name, gender, phoneNumber, address) == 1)
            {
                return "REGISTER success";
            }

            return "REGISTER user failed";
        }
    }
}