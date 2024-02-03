int number = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 1; i <= number; i += 1)
{
    double sumNumbers = double.Parse(Console.ReadLine());
    sum = sum + sumNumbers;
}

Console.WriteLine(sum);