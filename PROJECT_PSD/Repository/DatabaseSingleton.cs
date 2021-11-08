using PROJECT_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Repository
{
    public class DatabaseSingleton
    {
        private static DatabaseCentuDYEntities db;

        private DatabaseSingleton()
        {

        }

        public static DatabaseCentuDYEntities getInstance()
        {
            if (db == null)
            {
                db = new DatabaseCentuDYEntities();
            }
            return db;
        }
    }
}