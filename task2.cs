using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sum = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] array = { 1,2,4,1,1,6,0,0,9 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int c = 0; c < 10; c++)
                {
                    if (array[i] == c)
                    {
                        sum[c]++;
                        break;
                    }
                }

            }
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x+"="+sum[x]);
            }



        }
    }
}
