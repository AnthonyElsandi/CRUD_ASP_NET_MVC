using PROJECT_PSD.Factory;
using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Repository
{
    public class UserRepository
    {
        private static DatabaseCentuDYEntities db = DatabaseSingleton.getInstance();

        public static List<User> GetAllUser()
        {
            return db.Users.ToList();
        }

        public static User GetUser(string username, string password)
        {
            return (from x in db.Users where x.user_username == username && x.user_password == password select x).FirstOrDefault();
        }

        public static User GetUserByUsername(string username)
        {
            return (from x in db.Users where x.user_username == username select x).FirstOrDefault();
        }

        public static List<VIEW_USERS_Model> GetAllMember()
        {

            List<VIEW_USERS_Model> users = (from x in db.Users
                                            join y in db.Roles
                                            on x.role_id equals y.role_id
                                            where x.role_id == 2
                                            select new VIEW_USERS_Model()
                                            {
                                                user_id = x.user_id,
                                                user_username = x.user_username,
                                                user_name = x.user_name,
                                                role_name = x.Role.role_name,
                                                user_gender = x.user_gender,
                                                user_phone_number = x.user_phone_number,
                                                user_address = x.user_address
                                            }).ToList();
            return users;
        }

        public static int InsertUser(string username, string password, string name, string gender, string phoneNumber, string address)
        {
            db.Users.Add(UserFactory.createUser(username, password, name, gender, phoneNumber, address));
            return db.SaveChanges();
        }

        public static int UpdateProfile(int userId, string name, string gender, string phoneNumber, string address)
        {
            User user = db.Users.Find(userId);

            if (user != null)
            {
                user.user_name = name;
                user.user_gender = gender;
                user.user_phone_number = phoneNumber;
                user.user_address = address;
                return db.SaveChanges();
            }

            return 0;
        }

        public static int ChangePassword(int userId, string newPassword)
        {
            User user = db.Users.Find(userId);

            if (user != null)
            {
                user.user_password = newPassword;
                return db.SaveChanges();
            }

            return 0;
        }


        public static int DeleteUserById(int id)
        {
            User u = db.Users.Find(id);
            db.Users.Remove(u);
            return db.SaveChanges();
        }
    }
}