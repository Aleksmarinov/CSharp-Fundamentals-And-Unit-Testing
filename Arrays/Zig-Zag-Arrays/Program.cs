int count = int.Parse(Console.ReadLine());

List<int> firstList = new List<int>();
List<int> secondList = new List<int>();


for (int i = 0; i < count; i++)
{
    List<int> numbers = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();
    int num1 = numbers[0];
    int num2 = numbers[1];

    if (i % 2 == 0)
    {
        firstList.Add(num1);
        secondList.Add(num2);
    }
    else
    {
        firstList.Add(num2);
        secondList.Add(num1);
    }
}

Console.WriteLine(string.Join(" ", firstList));
Console.WriteLine(string.Join(" ", secondList));
