using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int [10] { 1,43,65,-43,-54,2,4,45,-34,76};
            Array.Sort(vet);
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.ReadKey();
        }
    }
}
