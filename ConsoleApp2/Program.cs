using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = Input("h= ");
            int m = Input("m= ");
            int s = Input("s= ");
            int rez= Second(h, m, s);
            Output(rez);
            Console.ReadLine();

        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static int Second(int h,int m,int s)
        {
            return h*3600+m*60+s;
        }
        public static void Output(int rez)
        {
            Console.WriteLine($"rez={rez}");
        }
    }
}
