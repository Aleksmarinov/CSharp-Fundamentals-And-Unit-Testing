int n = int.Parse(Console.ReadLine());
double sum = 0;
int i = 1;

while (i <= n)
{
    double number = double.Parse(Console.ReadLine());
    sum += number;
    i++;
}
Console.WriteLine(sum);