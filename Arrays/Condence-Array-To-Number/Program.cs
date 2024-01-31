var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
var count = inputArray.Length;

while(count > 1) 
{
    for (int i = 0; i < count - 1; i++)
    {
        inputArray[i] = inputArray[i] + inputArray[i + 1];
    }
    count--;
}

Console.WriteLine(inputArray[0]);