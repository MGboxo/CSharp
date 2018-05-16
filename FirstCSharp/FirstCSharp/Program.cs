using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
         //############################################
            //Lesson 1
            Console.WriteLine("Cerber");
            Console.WriteLine(DateTime.Now);
            //############################################
            //Lesson 2
            //Brak użytkowania przestrzeni nazw System

            //System.Console.WriteLine("Cerber");
            //System.Console.WriteLine(DateTime.Now);
            //############################################
            //Lesson 3
            //String Name = args[0];
            //Console.WriteLine("Witaj, " + Name);
            //Lesson 3.5
            foreach (var item in args)
            {
                Console.WriteLine("witaj, " + item);
            }
        }
    }
}
