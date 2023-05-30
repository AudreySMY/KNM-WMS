using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNMLib.Models
{
    internal class User
    {
        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
