using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //Если я правильно понимаю, то сложность данного алгоритма - O(N³)
        //А операции "весом" в 1 опускаются
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) //O(N)
            {
                for (int j = 0; j < inputArray.Length; j++) //O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++) //O(N)
                    {
                        int y = 0;  //1
                        if (j != 0) //1
                        {
                            y = k / j;  //1
                        }
                        sum += inputArray[i] + i + k + j + y;   //1
                    }
                }
            }
            return sum;
        }
    }
}
