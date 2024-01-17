int[] firstNumber = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

int[] secondNumber = Console.ReadLine()
                     .Split(" ")
                     .Select(int.Parse) 
                     .ToArray();

bool isIdentical = true;

for(int index = 0; index <= firstNumber.Length - 1; index++)
{
    if (firstNumber[index] != secondNumber[index])
    {
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}