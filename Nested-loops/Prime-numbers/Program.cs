namespace _8._Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = startNumber; currentNumber <= endNumber; currentNumber += 1)
            {
                bool isPrime = true;
                int divider = 2;

                while (divider < endNumber)
                {
                    if (currentNumber == divider)
                    {
                        divider += 1;
                        continue;
                    }

                    if (currentNumber % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }

                    divider += 1;
                }

                if (isPrime)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}