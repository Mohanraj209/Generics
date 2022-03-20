using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine(" ---------** Test Maximum of Three Variables **--------- ");
            Generics_Example.FindIntMax(3, 2, 1);
            Generics_Example.GetMax(3.5f, 5.7f, 9.8f);
            Console.ReadKey();

        }
    }
}
