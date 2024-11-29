using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = Input("r= ");
            int k = Input("k= ");
            int rez= Kop(r, k);
            Output(rez);
            Console.ReadLine();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static int Kop(int r,int k)
        {
            return r * 100 + k;
        }
        public static void Output(int rez)
        {
            Console.WriteLine($"rez={rez}");
        }
    }
}
