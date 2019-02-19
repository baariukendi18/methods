using System;
using System.Dynamic;
using System.Globalization;
using Microsoft.VisualBasic.CompilerServices;


namespace Kendi
{
    class Program
    {
        static void Main(string[] args)
        {
            

            GetName();
           // Add(3,8);
            Console.WriteLine("Enter your values");
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());
            int summ = Add(value1, value2);
            Console.WriteLine("The summ is{0} ",summ);
          //  String name = GetName();
           // int sum = Add(6,9);
          //  Console.WriteLine("The name is {0}while sum is {1}", name, sum);
            Console.ReadKey();
        }
       static string GetName()
        {
            Console.WriteLine("Enter my name");
            String name = Console.ReadLine();
            return name;
          
        }

        static int Add(int number1, int number2)
        {
           /* Console.WriteLine("Enter your numbers");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());*/
            int result = number1 + number2;
          //  Console.WriteLine("The sum is:{0}",result);
            return result;
        }
        
    }

}
