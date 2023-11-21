int daysCount = int.Parse(Console.ReadLine());

for (int currentDay = daysCount; currentDay >= 1; currentDay -= 1)
{
    Console.WriteLine($"{currentDay} days before the exam");
}
Console.WriteLine("The exam has come");