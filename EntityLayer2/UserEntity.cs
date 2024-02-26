using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer2
{
    public class UserEntity
    {
        private string username;
        private string password;
        private int ıd;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => ıd; set => ıd = value; }
    }
}
