using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Shoppy.Database
{
	class CamAdmin
	{
        public DataTable GetCams()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from kamera", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void DeleteCam(String id)
        {
            Abfragen.Delete("delete from kamera where id_kamera='" + id + "';");
        }
	}
}
