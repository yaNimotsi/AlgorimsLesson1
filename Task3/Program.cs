using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            UnrecursionMethod(5);
        }

        static int UnrecursionMethod(int inputVal)
        {
            int sum = 0;
            int[] fibonachi = new int[inputVal - 1];
            fibonachi[0] = 0;
            fibonachi[1] = 1;

            if (inputVal > 2)
            {
                for (int i = 2; i < inputVal - 1; i++)
                {
                    fibonachi[i] = fibonachi[i - 1]+ fibonachi[i - 2];
                    sum += fibonachi[i - 1] + i;
                }
            }
            
            return sum;
        }
    }
}
