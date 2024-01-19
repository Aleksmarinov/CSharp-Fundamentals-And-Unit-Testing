List<int> input = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToList();

List<int> output = new List<int>();

//int num1 = input[0] + input[input.Count - 1];
//int num2 = input[0 + 1] + input[input.Count - 1 - 1];
//int num3 = input[0 + 2];

//output.Add(num1);
//output.Add(num2);
//output.Add(num3);

for(int i = 0; i < input.Count / 2; i++)
{
    int sum = input[0 + i] + input[input.Count - 1 - i];
    output.Add(sum);
}

if (input.Count % 2 != 0) // Означава че броя стойности е различен от 0;
{
    int num = input[input.Count / 2];
    output.Add(num);
}

Console.WriteLine(string.Join(" ", output));
