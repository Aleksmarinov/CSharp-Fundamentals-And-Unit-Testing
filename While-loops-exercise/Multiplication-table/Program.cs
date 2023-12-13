int number = int.Parse(Console.ReadLine());

int i = 1;

while (i <= 10)
{
    int result = number * i;
    Console.WriteLine($"{number} x {i} = {result}");
    i++;
}