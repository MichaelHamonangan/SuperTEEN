using System;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;

namespace ModulDatabase
{
    //class akan sejumlah 3 untuk 3 modul yaitu kesehatan, belajar dan motivasi
    public class KesehatanData
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
        
        public KesehatanData()
        {
            //constructor
        }


        public int Create()
        {
            return 0;
        }

        public static KesehatanData[] Read()
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
