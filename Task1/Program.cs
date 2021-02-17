using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckEasy();
        }

        static void CheckEasy()
        {
            //n - задается входным значением
            int n =50, d = 0, i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else i++;
            }

            if (d == 0)
                Console.WriteLine("Простое");
            else
                Console.WriteLine("Не простое");

        }
    }
}
