using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHarness2
{
    public class LoginRequest
    {
        public LoginRequest(string user, string pwd)
        {
            username = user;
            password = pwd;
        }
        public string username;
        public string password;
    }
}
