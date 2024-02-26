using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer2;

namespace BusinessLayer2
{
    public class BLLmessage
    {
        public static int AddMessageBLLL(EntityChat p)
        {
            if (p.Chat != null && p.GroupName != null)
            {
                return Message.AddMessage(p);
            }
            else
            {
                return -1;
            }
        }
    }
}
