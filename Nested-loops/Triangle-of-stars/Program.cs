using System.Diagnostics.CodeAnalysis;

namespace _3.__Triangle_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            for (int row = 1; row <= n; row += 1)
            {
                for (int col = 1; col <= n; col += 1)
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }
}