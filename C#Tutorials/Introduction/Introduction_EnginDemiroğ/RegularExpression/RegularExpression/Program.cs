using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
            ////class Regex Repesents an immutable regular expression.  

            //string[] str = { "+91-9678967101", "9678967101", "+91-9678-967101", "+91-96789-67101", "+919678967101" };
            ////Input strings for Match valid mobile number.  
            //foreach (string s in str)
            //{
            //    Console.WriteLine("{0} {1} a valid mobile number.", s,
            //    r.IsMatch(s) ? "is" : "is not");
            //    //The IsMatch method is used to validate a string or  
            //    //to ensure that a string conforms to a particular pattern. 
            //}

            Regex regex = new Regex(@"(^[A-Z]{2}\d{8}$)|(^[A-Z]{3}\d{8}$)");
            string SeriesNumber = "AZEDF52655,AZE11122233,AA142522,AA07018773,AA55566688,AZE1236547";
            string[] arr = SeriesNumber.Split(',');
            foreach (string element in arr)
            {
                if (regex.IsMatch(element))
                {
                    Console.WriteLine("Dogru  " + element, Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("Yanlis  " + element, Environment.NewLine);
                }

            }
            Console.ReadLine();
        }
    }
}
