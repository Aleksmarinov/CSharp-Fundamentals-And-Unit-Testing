namespace _4._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorCount = int.Parse(Console.ReadLine());
            int roomCount = int.Parse(Console.ReadLine());

            for (int floor = floorCount; floor >= 1; floor -= 1)
            {
                for (int room = 0; room < roomCount; room += 1)
                {
                    if (floor == floorCount)
                    {
                        Console.WriteLine($"L{floor}{room}");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.WriteLine($"O{ floor}{room}");
                    }
                    else
                    {
                        Console.WriteLine($"A{floor}{room}");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
