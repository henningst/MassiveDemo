using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace MassiveDemo.DB
{
    public class DbUtils
    {
        //private static string DBNAME = string.Format("{0}\\{1}", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "MassiveDemoDb.sqlite");
        private static string DBNAME = "MassiveDemoDb.sqlite";

        public static void CreateDemoDatabase()
        {
            SQLiteConnection.CreateFile(DBNAME);

            var connection = new SQLiteConnection(string.Format("Data Source={0}", DBNAME));
            connection.Open();

            var command = new SQLiteCommand("CREATE TABLE Categories (id int, name varchar(29))", connection);
            command.ExecuteNonQuery();

            var insert = new SQLiteCommand("INSERT INTO Categories (id, name) VALUES (1, 'Test')", connection);
            insert.ExecuteNonQuery();
        }

        public static string GetStuff()
        {
            var connection = new SQLiteConnection(string.Format("Data Source={0}", DBNAME));
            connection.Open();

            var command = new SQLiteCommand("SELECT * FROM Categories", connection);
            var reader = command.ExecuteReader();
            var s = "";
            while (reader.Read())
            {
                s += reader[0].ToString();
            }
            return s;
        }

    }
}