using System;

namespace Pattern
{
    class Program
    {
        
        static void Main(string[] args)
        {


            int size = int.Parse(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (j <= i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
