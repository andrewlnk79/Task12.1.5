using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12._1._5
{
    internal class User 
    {
        
        internal string Name { get; set; }
        internal bool IsPremium { get; set; } = false;

        public User( string name, bool isPremium)
        {
            
            Name = name;
            IsPremium = isPremium;
        }
        internal void Hello(string Name)
        {
            Console.WriteLine("Hello {0}",Name);
        }


       
       
           
        

       
    }

}
