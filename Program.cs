using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgammingSchool
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1i dodatok");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2i dodatok");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = Add(x, y);
            Console.WriteLine($"summa:{sum}");

            Console.ReadKey();
        }
    }
}

