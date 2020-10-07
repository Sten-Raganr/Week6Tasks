using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            Random rnd = new Random();
         


            for(int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 11);
            }
            Console.WriteLine("sum of array :");
            Console.WriteLine(array1[0] + array1[1] + array1[2] + array1[3] + array1[4] + array1[5] + array1[6] + array1[7] + array1[8] + array1[9] );
        }
    }
}
