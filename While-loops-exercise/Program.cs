int number = int.Parse(Console.ReadLine()?? "0"); //Read an initial number from the input
string command = Console.ReadLine(); // Read an execute a sequence of the command

while (command != "End") // if command == "End" --> we end our loop
{
    if (command == "Inc") // "Inc" – add 1 to the number (increment)
    {
        number ++;
    }
    else if (command == "Dec") // "Dec" – subtract 1 from the number (decrement)
    {
        number --;
    }
    command = Console.ReadLine();
}

Console.WriteLine(number); 