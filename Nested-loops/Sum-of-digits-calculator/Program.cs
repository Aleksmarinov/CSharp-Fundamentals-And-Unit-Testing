namespace _7._Sum_of_Digits_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                int numberToProcess = int.Parse(command);
                int sum = 0;

                for (int number = numberToProcess; number > 0; number /= 10)
                {
                    int digit = number % 10;
                    sum += digit;
                }

                Console.WriteLine($"Sum of digits = {sum}");

                command = Console.ReadLine();
            }
            Console.WriteLine("Goodbye");
        }
    }
}
