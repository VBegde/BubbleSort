using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizi kaç elemanlı olsun?");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[sayi];
            for(int i=0;i<sayi;i++)
            {
                Console.Write("A[{0}]=",i);
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi - 1; j++)
                {
                    if (A[j + 1] < A[j])
                    {
                        int degistir = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = degistir;
                    }

                }
            }
            Console.WriteLine("\n Sıralanmış dizi:");
            Console.WriteLine();

            for (int k = 0; k < sayi; k++)
                Console.WriteLine("A[{0}]={1}", k, A[k]);

            Console.ReadKey();

        }
    }
}
