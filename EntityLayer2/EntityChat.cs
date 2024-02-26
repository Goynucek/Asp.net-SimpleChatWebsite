using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer2
{
    public class EntityChat
    {
        private string username;
        private string chat;
        private string groupname;

        private string[] message;

        public string Username { get => username; set => username = value; }
        public string Chat { get => chat; set => chat = value; }
        public string GroupName { get => groupname; set => groupname = value; }
        public string[] Message { get => message; set => message = value; }
    }
}
