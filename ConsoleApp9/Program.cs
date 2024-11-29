using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a= ");
            int b = Input("b= ");
            Console.WriteLine($"z={Min(a, b)+Min1(a, b)}");
            Console.ReadLine();

        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static int Min(int a, int b)
        {
            return a < b ? 2*a : b+a;
        }
        public static int Min1(int a, int b)
        {
            return a < b ? 2 * a - b : b;
        }
    }
}
