using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KushnerovIA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KushnerovIA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(12, 6));
            Console.WriteLine("A - B = " + DataService.Substraction(12, 6));
            Console.WriteLine("A * B = " + DataService.Multiplication(12, 6));
            Console.WriteLine("A / B = " + DataService.Division(12, 6));
            
            Console.ReadKey();
        }
    }
}
