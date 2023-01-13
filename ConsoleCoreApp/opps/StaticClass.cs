using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.opps
{
    static internal class StaticClass
    {
    //    int id;//non static data field
        static int count;//static data field

        //public StaticClass()
        //{
        //    this.id = count++;
        //}

        //public void displayID()
        //{
        //    Console.WriteLine($"{id}");
        //}
        public static void displayCount()
        {
            Console.WriteLine($"object create:{count}");
        }

        static StaticClass()
        {
            count = 0;
        }
    }
}
