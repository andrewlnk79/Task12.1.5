using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12._1._5
{
    internal class User
    {
        internal string Login { get; set; }
        internal string Name { get; set; }
        internal bool IsPremium { get; set; } = true;

        public User(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }

    }

}
