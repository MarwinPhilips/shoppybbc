using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Shoppy.Database
{
	class Abfragen
    {
        private static string verbindung = "Data Source=127.0.0.1; User=root;Password=pw; Database=tierheim;";
        private static MySqlConnection conn = new MySqlConnection(verbindung);
        private MySqlCommand command = conn.CreateCommand();
        private MySqlDataReader reader;
        
        public Abfragen()
        {
        }

        public string[,] Select(String query)
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

        public void Insert(String query)
        {
            setCommandText(query);
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            command.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(String query)
        {
            Insert(query);
        }
        public void Delete(String query)
        {
            Insert(query);
        }

        private void setCommandText(String query)
        {
            command.CommandText = query;
        }
    }
}
