using System;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;

namespace UserDatabase
{
    public class UserData
    {
        private static OleDbConnection dbConnection;
        private static OleDbCommand dbCommand;
        private static OleDbDataReader dataReader;

        private static string conn;
        public static void SetConnectionString(string connection)
        {
            conn = connection;
        }

        //data + polymorphism disini

        public UserData()
        {
            //constructor
        }


        public int Create()
        {
            return 0;
        }

        public static UserData[] Read()
        {
            //membaca data
            return null;
        }
        public int Update(int id)
        {
            return 0;
        }
        public int Delete(int id)
        {
            return 0;
        }
    }
}
