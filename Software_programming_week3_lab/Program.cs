// conditional statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CSharpTutorials
{
    class program
    {
        static void Main(string[] args)
        {
            //simple calculator

            Console.WriteLine("Enter number 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter 1 for + \n Enter 2 for - \n enter 3 for * \n enter 4 for + /");

            Console.WriteLine("Enter your choice between 1 to 4:");
            int op = Convert.ToInt32(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Console.WriteLine(n1 + n2);
                    break;
                case 2:
                    Console.WriteLine(n1 - n2);
                    break;
                case 3:
                    Console.WriteLine(n1 * n2);
                    break;
                case 4:
                    Console.WriteLine(n1 / n2);
                    break;
                default: 
                    Console.WriteLine("Bad input");
            }
            //switch case

            int day = 1;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday"); break;
                case 2:
                    Console.WriteLine("Tuesday");break;
                default:
                    Console.WriteLine("Bad input");
            }
            if(day == 1)
            {
                
            }
            int a = 5;
            int b = 6;
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if(a == b)
            {
                Console.WriteLine("both a and b are equal.");
            }
            else
            {
                Console.WriteLine(b);
            }
            //short hand if..else

            int output = (a > b) ? a : b;
            Console.WriteLine(output);
        }

        /*if(condition){do somthing when condition is true}
         else{do somthing when conditin is false} 
         */
    }
}
