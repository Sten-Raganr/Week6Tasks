using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 11);
            }
            
        int min = array[0];
        int max = array[0];
            foreach(int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
                
            }
            Console.WriteLine($"min:{min}");
            Console.WriteLine($"max:{max}");
        }
    }
}
