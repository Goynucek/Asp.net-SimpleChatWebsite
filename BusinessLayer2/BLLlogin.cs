﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer2;

namespace BusinessLayer2
{
    public class BLLlogin
    {
        public static int UserLog(UserEntity p)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LogIn_Table", Baglanti.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                string name = reader["Username"].ToString();
                if (name == p.Username)
                {
                    string Password = reader["Password"].ToString();
                    if (Password == p.Password)
                    {
                        
                    }
                }
            }

            reader.Close();
            return 0;
        }
    }
}
