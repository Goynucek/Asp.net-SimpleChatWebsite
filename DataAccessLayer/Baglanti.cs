using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection con = new SqlConnection(@"Server=DESKTOP-UQGF5P1\SQLEXPRESS;Database=ChatDB;Trusted_Connection=True;");
    }
}
