using System;

namespace n.n_matris
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Matris kaça kaçlık olsun?");
                int n = Convert.ToInt32(Console.ReadLine());
                int[,] matris = new int[n, n];
                matris = matris_oluştur(n);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matris[i, j].ToString());
                    }
                    Console.WriteLine();
                }
                ust_ucgen(n, matris_oluştur(n));
                alt_ucgen(n, matris_oluştur(n));
                Console.ReadKey();
            }
            static int[,] matris_oluştur(int n)
            {
                int[,] matris = new int[n, n];
                int say = 0;
                int bas = 1;
                while (say < n)
                {
                    int i = 0;
                    while (i < n)
                    {
                        matris[say, i] = bas + i;
                        i++;
                    }
                    bas++;
                    say++;
                }
                return matris;
            }
            static void ust_ucgen(int n, int[,] matris)
            {
                Console.WriteLine("\nÜst üçgen");
                int ss = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < ss; j++)
                    {
                        matris[i, j] = 0;
                    }
                    ss++;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matris[i, j].ToString());
                    }
                    Console.WriteLine();
                }
            }
            static void alt_ucgen(int n, int[,] matris)
            {
                Console.WriteLine("\nAlt üçgen");
                int bas = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = (n - 1); j > bas; j--)
                    {
                        matris[i, j] = 0;
                    }

                    bas++;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matris[i, j].ToString());
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
