int limit = int.Parse(Console.ReadLine());

int number = 1;

while (number <= limit)
{
    Console.WriteLine(number);
    number = number * 2 + 1;
}