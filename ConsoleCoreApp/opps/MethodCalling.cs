using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.opps
{
    internal class MethodCalling
    {
        public void CallByValue(int x,int y)
        {
            x = x + 20;
            y = y + 30;

            Console.WriteLine($"x:{x} , y:{y}");
        }

        //method for call by reference by ref keyword
        public void CallByRef(ref int x,ref int y)
        {
            x = x + 20;
            y = y + 30;

            Console.WriteLine($"x:{x} , y:{y}");
        }
        
        
        //method for call by refernce by out keyword
        public void CallByout(int x, int y ,out int sum,out int sub)
        {
            sum = x + 20;
            sub= y - 30;
        }

        //method for call by Named and optional
        public void CallByNamedOptional(int id,string fname,string sname="shinde",float salary=12345)
        {
            Console.WriteLine($"id:{id}  firstname:{fname}  sirname:{sname}  salary:{salary}");
        }
    }
}
