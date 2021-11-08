using PROJECT_PSD.Handler;
using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Controller
{
    public class UserController
    {
        public static string UpdateProfile(int userId, string name, string gender, string phoneNumber, string address)
        {
            if (UserHandler.UpdateProfile(userId, name, gender, phoneNumber, address) != 0) return "Update Profile Success";

            return "Update Profile Failed";
        }

        public static string DeleteUserById(int id)
        {
            if (UserHandler.DeleteUserById(id) != 0) return "Delete Success";

            return "Delete Failed";
        }
        public static List<VIEW_USERS_Model> GetAllMember()
        {
            return UserHandler.GetAllMember();
        }

        public static string ChangePassword(string username, string oldPassword, string newPassword, string confirmPassword)
        {
            User u = UserHandler.GetUserByUsername(username);

            if (oldPassword != u.user_password) return "Old Password Must match with the password in database and Cannot be empty";

            if (newPassword.Length < 5 || newPassword == "") return "Password Must be longer than 5 characters and Cannot be empty";

            if (newPassword != confirmPassword) return "New Password Must match old password and Cannot be empty";

            int status = UserHandler.ChangePassword(u.user_id, newPassword);

            if (status != 0) return "Update Password Success";

            return "Update Password Failed";
        }
    }
}