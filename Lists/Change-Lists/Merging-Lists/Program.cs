List<int> number1 = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToList();

List<int> number2 = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToList();


List<int> output = new List<int>();


int longerCount = Math.Max(number1.Count, number2.Count);

for (int i = 0; i < longerCount; i++)
{
    if (i < number1.Count)
    {
        output.Add(number1[i]);

    }

    if (i < number2.Count)
    {
        output.Add(number2[i]);
    }
}

Console.WriteLine(string.Join(" ", output));
