using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KushnerovIA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KushnerovIA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(12, 6));
            Console.WriteLine(DataService.Substraction(12, 6));
            Console.WriteLine(DataService.Division(12, 6));
            Console.WriteLine(DataService.Multiplication(12, 6));
            Console.ReadKey();

        }
    }
}
