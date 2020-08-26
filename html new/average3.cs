using System;

namespace ConsoleApp30
{
    class Average
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }
        public void  Calculate(int num1,int num2,int num3 )
        {
            int avr;
            Number1 = num1;
            Number2 = num2;
            Number3 = num3;
            avr = (num1 + num2 + num3) / 3;
            Console.WriteLine(" average is " + avr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Average a = new Average();
            Console.WriteLine(" enter three numbers ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            a.Calculate(n1, n2, n3);
            Console.ReadKey();
        }
    }
}
