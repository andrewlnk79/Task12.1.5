using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12._1._5
{
    internal class User : IAdwersting
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

        public void Games()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        }

        public void Music()
        {
            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        }

        public void Subscribe()
        {
            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        }



    }

}
