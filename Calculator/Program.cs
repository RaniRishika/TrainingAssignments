using System;

namespace Calculator
{
   public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int  Multiply(int num1, int num2)
        {
                     return num1 + num2;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe sum of two numbers is : {0", Add(num1, num2));
            Console.WriteLine("\nThe sum of two numbers is : {0}", Substract(num1, num2));
            Console.WriteLine("\nThe sum of two numbers is : {0}", divide(num1, num2));
            Console.WriteLine("\nThe sum of two numbers is : {0}", Multiply(num1, num2));
              Console.ReadLine();


        }
    }
}
