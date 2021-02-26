using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] value1 = { 1, 2, 3, 4 };
            int[] value2 = { 2, 5 };
            var result = value2.Except(value1);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
