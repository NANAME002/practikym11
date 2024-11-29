using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = Input("K= ");
            int m = Input("m= ");
            int rez =Meters(k, m);
            Output(rez);
            Console.ReadLine();
        }
        public static int Meters(int k,int m)
        {
            return k * 1000 + m;
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
