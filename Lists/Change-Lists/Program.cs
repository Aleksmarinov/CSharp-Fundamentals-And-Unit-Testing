List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];
    int element = int.Parse(commandParts[1]);

    if (commandName == "Delete")
    {
        numbers.RemoveAll(number => number == element);
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(commandParts[2]);
        numbers.Insert(position, element);
    }
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));