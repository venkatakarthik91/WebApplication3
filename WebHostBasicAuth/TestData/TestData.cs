using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHostBasicAuth.TestData
{
    public class Roles
    {
        public const string read = "read";
        public const string write = "write";
        public const string fullControl = "full control";
    }
    public class User
    {
        private string userName;
        private string password;
        private string[] roles;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string[] Roles
        {
            get
            {
                return roles;
            }

            set
            {
                roles = value;
            }
        }
    }
    public static class TestData
    {
        public static User karthik;
        public static User achu;
        public static User anju;
        public static List<User> users;
        static TestData()
        {
            //Karthik
            karthik = new User();
            karthik.UserName = "karthik";
            karthik.Password = "password";
            karthik.Roles = new string[3] { Roles.read, Roles.write, Roles.fullControl };
            //Achu
            achu = new User();
            achu.UserName = "achu";
            achu.Password = "password";
            achu.Roles = new string[2] { Roles.read, Roles.write };
            //Anju
            anju = new User();
            anju.UserName = "anju";
            anju.Password = "password";
            anju.Roles = new string[1] { Roles.read };
            users = new List<User>() { karthik, achu, anju };
        }
        public static User GetUserFromUserName(string userName)
        {
            foreach (User user in users)
            {
                if (user.UserName.Equals(userName,StringComparison.OrdinalIgnoreCase))
                {
                    return user;
                }
            }
            return null;
        }
    }
}
