using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TocharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "terlan;";
            char[] chr = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (chr[i] == 'a')
                {
                    Console.WriteLine("+");
                   
                }
                else
                {
                    Console.WriteLine("-");
                }

            }
            Console.ReadLine();
        }
    }
}
