using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a= ");
            int b = Input("b= ");
            int c = Input("c= ");
            int rez= Max(Max(a,b),c);
            Output(rez);
            Console.ReadKey();

        }
        public static int Max(int a, int b)
        {
            return a>b?a:b;
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
