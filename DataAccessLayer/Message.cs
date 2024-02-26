using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer2;

namespace DataAccessLayer
{
    public class Message
    {
        public static int AddMessage(EntityChat parametre)
        {
            SqlCommand cmd = new SqlCommand("Insert into Chat_Table (Username, Chat, GroupName) values (@p1, @p2, @p3)", Baglanti.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.Parameters.AddWithValue("@p1", parametre.Username);
            cmd.Parameters.AddWithValue("@p2", parametre.Chat);
            cmd.Parameters.AddWithValue("@p3", parametre.GroupName);


            return cmd.ExecuteNonQuery();
        }
    }
}
