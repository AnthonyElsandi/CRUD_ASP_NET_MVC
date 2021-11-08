using PROJECT_PSD.Model;
using PROJECT_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Handler
{
    public class UserHandler
    {
        public static User GetUser(string username, string password)
        {
            return UserRepository.GetUser(username, password);
        }

        public static int InsertUser(string username, string password, string name, string gender, string phoneNumber, string address)
        {
            return UserRepository.InsertUser(username, password, name, gender, phoneNumber, address);
        }

        public static List<VIEW_USERS_Model> GetAllMember()
        {
            return UserRepository.GetAllMember();
        }

        public static int DeleteUserById(int id)
        {
            CartRepository.DeleteCartByUserId(id);
            List<int> headerTrIds = HeaderTransactionRepository.GetHeaderTransactionIdsByUserId(id);
            if (headerTrIds.Count != 0)
            {
                DetailTransactionRepository.DeleteDetailTransactions(headerTrIds);
            }
            HeaderTransactionRepository.DeleteHeaderTransactionByUserId(id);
            return UserRepository.DeleteUserById(id);
        }

        public static User GetUserByUsername(string username)
        {
            return UserRepository.GetUserByUsername(username);
        }

        public static int UpdateProfile(int userId, string name, string gender, string phoneNumber, string address)
        {
            return UserRepository.UpdateProfile(userId, name, gender, phoneNumber, address);
        }

        public static int ChangePassword(int userId, string newPassword)
        {
            return UserRepository.ChangePassword(userId, newPassword);
        }
    }
}