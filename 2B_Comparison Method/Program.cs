using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2B_Comparison_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isValue30(30,0));
            Console.WriteLine(isValue30(25,5));
            Console.WriteLine(isValue30(20,30));
            Console.WriteLine(isValue30(20,25));
            Console.ReadLine();
        }
        //Method to check two given integers,
        //and return true if one of them is 30 or if their sum is 30.
        public static bool isValue30(int num1, int num2)
        {
            int sum = num1 + num2;
            if(num1 ==30 || num2 ==30 || sum == 30) { 

                return true; 
            }
            else { 

                return false; 
            }

        }
    }
}
