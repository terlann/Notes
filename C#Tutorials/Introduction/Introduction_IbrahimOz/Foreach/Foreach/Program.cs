using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] karakterler = { 'A', 'B', 'f' };
            foreach (char item in karakterler)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
