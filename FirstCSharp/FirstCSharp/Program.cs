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

            //Lesson 1 [Pierwsze komendy]
            Console.WriteLine("Hello");
            Console.WriteLine(DateTime.Now);
            //############################################

            //Lesson 2 [Przydatność przestrzeni nazw]
            //Brak użytkowania przestrzeni nazw System
            //System.Console.WriteLine("Cerber");
            //System.Console.WriteLine(DateTime.Now);
            //############################################

            //Lesson 3 [Stringi i argumenty]
            String Name = args[0];
            Console.WriteLine("Witaj, " + Name);
            //############################################

            //Lesson 3.5 [Pierwsza pętla]
            //foreach (var item in args)
            //{
            //    Console.WriteLine("witaj, " + item);
            //}
            //############################################
            
            //Lesson 4


        }
    }
}
