using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_shape
{
    class Program
    {
        static void Main(string[] args)
        { empty_tringle_down_base();
            empty_tringle_up_base();
            fourth_pyramid();
            empty_square();
            empty_m3yn();
            m3yn();
            pyramids();

        }
        static void empty_tringle_up_base()
        {
            int h = int.Parse(Console.ReadLine());
            for (int x = 1; x <= h; x++)
            {
                for (int y = 1; y <= 2 * h - 1; y++)
                {
                    if (x == 1 || x == y || x + y == 2 * h)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void pyramids()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            for (int x = 1; x <= n; x++)
            {
                for (int z = 1; z <= n - x; z++)
                {

                    Console.Write(" ");
                }
                for (int v = 1; v <= x; v++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

        }
        static void m3yn()
        {
            for (int x = 1; x <= 4; x++)
            {
                for (int k = 1; k <= 4 - x; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= x; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine("* * * * *");
            for (int z = 4; z >= 1; z--)
            {
                for (int h = 1; h <= 4 - z; h++)
                {
                    Console.Write(" ");
                }
                for (int r = 1; r <= z; r++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        static void empty_m3yn()
        {
            for (int x = 1; x <= 9; x++)
            {
                for (int z = 1; z <= 9; z++)
                {  
                    if (x - z == 4 || x + z == 6 || z - x == 4 || z + x == 14)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void empty_square()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            for (int x = 1; x <= n; x++)
            {
                for (int z = 1; z <= n; z++)
                {
                    if (z == 1 || z == n || x == n || x == 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void empty_tringle_down_base()
        {
            int n = int.Parse(Console.ReadLine());


            for (int x = 1; x <= n; x++)
            {
                for (int z = 1; z <= n * 2 - 1; z++)
                {
                    if (x == n || x + z == n + 1 || z - x == n - 1)

                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void fourth_pyramid()
        {
            int n = int.Parse(Console.ReadLine());


            for (int x = 1; x <= n; x++)
            {
                for (int z = 1; z <= n * 2 - 1; z++)
                {
                    if (x == z || x + z == n + 1 || z - x == n - 1)

                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
        