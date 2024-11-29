using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = Input("m= ");
            int c = Input("c= ");
            int rez = Centimeters(m, c);
            Output(rez);
            Console.ReadKey();

        }
        public static int Centimeters(int m, int c)
        {
            return m * 100 + c;
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Output(int rez)
        {
            Console.WriteLine($"rez={rez}");
        }
    }
}
