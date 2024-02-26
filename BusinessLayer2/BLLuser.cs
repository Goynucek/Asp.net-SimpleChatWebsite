using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer2;

namespace BusinessLayer2
{
    public class BLLuser
    {
        public static  int UserAddBLL(UserEntity p)
        {
            if (p.Id != null && p.Password != null && p.Username != null)
            {
                return SignUser.AddUser(p);
            }
            else
            {
                return -1;
            }
        }
    }
}
