using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Shoppy.Database
{
	static class Abfragen
    {
        public static string verbindung = "Data Source=172.16.2.63; User=shoppy;Password=bbc; Database=shoppy;";
        public static MySqlConnection conn = new MySqlConnection(verbindung);
        private static MySqlCommand command = conn.CreateCommand();
        private static MySqlDataReader reader;
        

        public static string[,] Select(String query)
        {
            setCommandText(query);
            command.CommandText = query;
            int counterh = 0;
            int counterw = 0;
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                string[,] bla = new string[0,0];
                return bla;
            }

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string text = reader.GetValue(0).ToString();
                counterh++;
                if (reader.FieldCount > counterw) {
                    counterw = reader.FieldCount;
                }
            }
            reader.Close();
            string[,] rueckgabe = new string[counterh,counterw];
            int i = 0;
            reader = command.ExecuteReader();
            while (reader.Read() && i < counterh)
            {
                for (int j = 0; j < counterw; j++)
                {
                    rueckgabe[i, j] = reader.GetValue(j).ToString();
                }
                i++;
            }
            reader.Close();
            conn.Close();
            return rueckgabe;
        }

        public static void Insert(String query)
        {
            setCommandText(query);
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                
                return;
            }

            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update(String query)
        {
            Insert(query);
        }
        public static void Delete(String query)
        {
            Insert(query);
        }

        private static void setCommandText(String query)
        {
            command.CommandText = query;
        }
    }
}
