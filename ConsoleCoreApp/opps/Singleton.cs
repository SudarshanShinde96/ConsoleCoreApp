using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.opps
{
    internal class Singleton
    {
         static Singleton _Singleton;
        private Singleton() 
        {
           
        }

        public static Singleton getObject ()
        {
            if (_Singleton == null)
                return new Singleton();
            else
                return _Singleton;
        }
        public void msg()
        {
            Console.WriteLine("one object created");
        }
    }
}
