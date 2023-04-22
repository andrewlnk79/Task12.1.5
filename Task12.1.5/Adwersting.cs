using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12._1._5
{
    internal class Adwersting : IAdwersting
    {
        public Adwersting()
        {
        }
        public void ShowAdws()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        }

        public void Subscribe()
        {
            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        }
    }
}
