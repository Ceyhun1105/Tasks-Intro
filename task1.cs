using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 324, 23, 43, 123, 24 };
            int c;
            int sum = 0;
            int say = 0;

            for (int i = 0; i < array.Length; i++)
            {
                c = array[i];
                
                while (array[i] > 0)
                {
                    array[i] /= 10;
                    say++;

                }

                if (say > 2)
                {

                    sum += c;

                }
                say = 0;
            }
            Console.WriteLine(sum);
        }

    }
}


