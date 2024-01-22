using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());

        if (input == "add")
        {
            Add(numberOne, numberTwo);
        }
        else if (input == "substract")
        {
            Substract(numberOne, numberTwo);
        }
        else if (input == "multiply")
        {
            Multiply(numberOne, numberTwo);
        }
        else if (input == "divide")
        {
            Divide(numberOne, numberTwo);
        }
    }

    private static void Add(int numberOne, int numberTwo)
    {
        int result = numberOne + numberTwo;
        Console.WriteLine(result);
    }

    private static void Substract(int numberOne, int numberTwo)
    {
        int result = numberOne - numberTwo;
        Console.WriteLine(result);
    }

    private static void Multiply(int numberOne, int numberTwo)
    {
        int result = numberOne * numberTwo;
        Console.WriteLine(result);
    }

    private static void Divide(int  numberOne, int numberTwo)
    {
        int result = numberOne / numberTwo;
        Console.WriteLine(result);
    }
}

