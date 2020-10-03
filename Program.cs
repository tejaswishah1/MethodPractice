using System;

namespace Method
{
    class Program
    {
      public  static void Main(string[] args)
        {
            Program.CalculateEvenNumber(50);
        }
        public static void CalculateEvenNumber(int target)
        {
            Console.WriteLine("Enter the number");
            int num1 = 0;
            num1 = Convert.ToInt32(Console.ReadLine());

            while (num1 <= target)
            {
                Console.WriteLine(num1);
                num1 = num1 + 2;
            }
           
             

            
        }
           
    }
}
