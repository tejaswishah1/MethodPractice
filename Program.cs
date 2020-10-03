using System;

namespace Method
{
    class Program
    {
      public  static void Main(string[] args)
        {
            int SumIs = 0;
            int ProdIs = 0;

            int a = 0;
            Console.WriteLine("Enter first Number");
            a = Convert.ToInt32(Console.ReadLine());

            int b = 0;
            Console.WriteLine("Enter second Number");
            b = Convert.ToInt32(Console.ReadLine());

            Caclculate(a,b, out SumIs, out ProdIs);
            Console.WriteLine("The sum of 2 numbers is "+ SumIs);
            Console.WriteLine("The product of 2 numbers is "+ProdIs);



        }
        public static void Caclculate(int num1, int num2, out int Sum, out int Prod)
        {
            Sum = num1 + num2;
            Prod = num1 * num2;
        }
           
    }
}
