using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int[,] m1 = new int[8, 8];
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    if (a == 0)
                    {
                        a = 1;
                    }
                    else
                    {
                        a = 0;
                    }
                    m1[i, j] = a;
                    Console.Write(m1[i, j] + " ");
                }
                if (a == 0)
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            int[,] m = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = random.Next(-999, 999);
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine("\n\n");
            }


            Console.WriteLine("Суммы элементов строк, начиная с верхней");
            int sum = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    sum += m[i, j];
                }
                Console.Write(sum + "\t");
                sum = 0;
            }


            Console.WriteLine("\n\nПростые числа");
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    if (m[i, j] > 1)
                    {
                        bool prost = true;
                        for (int b = 2; b <= m[i, j] / 2; b++)
                        {
                            if (m[i, j] % b == 0)
                            {
                                prost = false;
                                break;
                            }
                        }
                        if (prost)
                        {
                            Console.Write(m[i, j] + "\t");
                        }
                    }
                }
            }
        }
    }
}
