using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkatTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat x;
            x = new Trojkat(2, 1, 3.2);
            Console.WriteLine(x);
            Console.WriteLine( x.Obwod() ); // funkcja Obwód
            Console.WriteLine( x.Obwód );   // properties get Obwod
        }
    }
}
