using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer2;

namespace BusinessLayer2
{
    public class LoadMessage
    {
        public static string[] LoadMes()
        {
            SqlCommand cmd = new SqlCommand("SELECT Chat FROM Chat_Table", Baglanti.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();

            var veriListesi = new List<string>();

            while (reader.Read())
            {
                veriListesi.Add(reader.GetString(0));
            }

            string[] kisiler = veriListesi.ToArray();
            reader.Close();
            return kisiler;
        }
    }
}
