using System;

namespace ConsoleAppSummation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, sum;
            Console.WriteLine("1.Sayıyı giriniz : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı giriniz : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.Sayıyı giriniz : ");
            n3 = Convert.ToInt32(Console.ReadLine());
            sum = n1 + n2 + n3;
            Console.WriteLine("{0} + {1} + {2} = {3}", n1, n2, n3, sum);
            Console.ReadKey();
        }
    }
}
