using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*   Assignment#01   */

            int n = 0, r = 0, sum = 0, temp = 0;
            
            Console.Write("Enter the Number: ");
            
            n = int.Parse(Console.ReadLine());
            
            temp = n;
            
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome!");
            else
                Console.Write("Number is not Palindrome!");

            Console.ReadLine();
        }
    }
}
