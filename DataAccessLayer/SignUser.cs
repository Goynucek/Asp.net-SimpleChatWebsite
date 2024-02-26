using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer2;

namespace DataAccessLayer
{
    public class SignUser
    {
        public static int AddUser (UserEntity parametre)
        {
            SqlCommand cmd = new SqlCommand("Insert into LogIn_Table (Username, Password) values (@p1, @p2)", Baglanti.con);
            if (cmd.Connection.State != ConnectionState.Open) {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1",parametre.Username);
            cmd.Parameters.AddWithValue("@p2", parametre.Password);

            return cmd.ExecuteNonQuery();
        } 

    }
}
