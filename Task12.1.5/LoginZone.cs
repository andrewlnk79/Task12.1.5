using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12._1._5
{
    internal class LoginZone : IAdwersting
    {
        IAdwersting Adwersting { get; }
        User user;
        public LoginZone(IAdwersting adwersting, User user)
        {
            Adwersting = adwersting;
            this.user = user;
        }

        public void ShowAdws()
        {
            if (user.IsPremium)
            {
                user.Hello(user.Name);
            }
            else
            {
                user.Hello(user.Name);
                Adwersting.ShowAdws();
                Adwersting.Subscribe();
            }
        }


        public void Subscribe()
        {
            Adwersting.Subscribe();
        }

        
    }
}
