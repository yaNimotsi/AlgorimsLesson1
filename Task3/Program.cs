using System;

namespace Task3
{
    class Program
    {
        static int[] fibonachiArr = new int[47];    //Массив имеет длину 47, тк дальше происходит переполнении типа INT, что в свою очередь требует смены типа массива 
        static void Main(string[] args)
        {
            int expected;
            int returnedVal;
            int inVal;

            Console.WriteLine("Поиск числа фибоначи без рекурсии");

            //InVal = 5; Expected = 3
            inVal = 5;
            returnedVal = UnrecursionMethod(inVal);
            expected = 3;

            if (expected == returnedVal) Console.WriteLine($"the UnRecouredmethod worked correctly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected} ");
            else Console.WriteLine($"the UnRecouredmethod worked UNcorrectly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected}");


            //InVal = 9; Expected = 21
            inVal = 9;
            returnedVal = UnrecursionMethod(inVal);
            expected = 21;

            if (expected == returnedVal) Console.WriteLine($"the UnRecouredmethod worked correctly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected} ");
            else Console.WriteLine($"the UnRecouredmethod worked UNcorrectly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected}");


            Console.WriteLine();

            Console.WriteLine("Поиск числа фибоначи с рекурсией");
            fibonachiArr[0] = 0;
            fibonachiArr[1] = 1;


            //InVal = 5; Expected = 3
            inVal = 5-1;    //-1 добавляется из-за работы с массивом. число фибоначи под номером 5 будет иметь 4 индекс в массиве
            returnedVal = RecursionMethod(inVal);
            expected = 3;

            if (expected == returnedVal) Console.WriteLine($"the Recouredmethod worked correctly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected} ");
            else Console.WriteLine($"the Recouredmethod worked UNcorrectly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected}");

            //InVal = 9; Expected = 21
            inVal = 9-1;    //-1 добавляется из-за работы с массивом. число фибоначи под номером 9 будет иметь 8 индекс в массиве
            returnedVal = RecursionMethod(inVal);
            expected = 21;

            if (expected == returnedVal) Console.WriteLine($"the Recouredmethod worked correctly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected} ");
            else Console.WriteLine($"the Recouredmethod worked UNcorrectly. InVal = {inVal} | outVal = {returnedVal} | Expected = {expected}");

        }

        static int UnrecursionMethod(int inputVal)
        {
            int[] fibonachi = new int[inputVal];
            fibonachi[0] = 0;
            fibonachi[1] = 1;

            if (inputVal > 2)
            {
                for (int i = 2; i < inputVal; i++)
                {
                    fibonachi[i] = fibonachi[i - 1]+ fibonachi[i - 2];
                }
                }
            
            return fibonachi[inputVal - 1];
            }
            
        static int RecursionMethod(int numIndex)
        {
            if (numIndex <= 1) return numIndex;

            if (fibonachiArr[numIndex] != 0) return fibonachiArr[numIndex];

            fibonachiArr[numIndex] = RecursionMethod(numIndex - 2) + RecursionMethod(numIndex - 1);
            return fibonachiArr[numIndex];
        }
    }
}
