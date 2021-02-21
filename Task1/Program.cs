using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string expected;
            string returnedVal;
            int inVal;

            //InVal = 50; Expected = "Не простое"
            inVal = 50; 
            returnedVal = CheckEasy(inVal);
            expected = "Пе простое";

            if (expected.ToLower() == returnedVal?.ToLower()) Console.WriteLine($"the method worked correctly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected} ");
            else Console.WriteLine($"the method worked UNcorrectly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected}");


            //InVal = 89; Expected = "Простое"
            inVal = 89;
            returnedVal = CheckEasy(inVal);
            expected = "Простое";
            
            if (expected.ToLower() == CheckEasy(inVal)?.ToLower()) Console.WriteLine($"the method worked correctly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected} ");
            else Console.WriteLine($"the method worked UNcorrectly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected}");

        }

        static string CheckEasy(int InVal)
        {
            //n - задается входным значением
            int n = InVal, d = 0, i = 2;
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
            {
                //Console.WriteLine("Простое");
                return "Простое";
            }
            //else
                //Console.WriteLine("Не простое");
            
            return "Не простое";

        }
    }
}
