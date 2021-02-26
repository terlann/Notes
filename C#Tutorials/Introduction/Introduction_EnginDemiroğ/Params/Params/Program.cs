using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int toplama(params int[] ededler)
            {
                return ededler.Sum();
            }

            Console.WriteLine(toplama(4, 5, 8, 9, 32, 1));
            Console.ReadLine();
           
        }
    }
}
