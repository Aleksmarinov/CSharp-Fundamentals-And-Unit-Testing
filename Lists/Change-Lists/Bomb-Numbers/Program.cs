List<int> input = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToList();

List<int> bomb = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToList();

int bombNum = bomb[0];
int bombPow = bomb[1];

for (int i = 0; i < input.Count; i++)
{
    if (input[i] == bombNum)
    {
        int startIndex = i - bombPow;
        int removeCount = bombPow + bombPow + 1;

        if (startIndex < 0)
        {
            removeCount -= Math.Abs(startIndex);
            startIndex = 0;
        }

        if (startIndex + removeCount > input.Count)
        {
            removeCount = input.Count - startIndex;
        }

        input.RemoveRange(startIndex, removeCount);
        i = startIndex - 1;
    }
}
int sum = input.Sum();
Console.WriteLine(sum);