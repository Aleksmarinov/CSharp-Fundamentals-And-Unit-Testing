int stopNumber = int.Parse(Console.ReadLine()); // число, което ако въведем спираме
// повтаряме : въвеждаме числа -> проверка дали съвпада с stopNumber
int previousNumber = stopNumber; // последното въведено число

while(true)
{
    int number = int.Parse(Console.ReadLine()); // въведено число
    if (number == stopNumber)
    {
        // 1. Увеличавам предното с 20 %
        // 2. принтирам
        // previousNumber + 20 % = previousNumber + 0.20 * previousNumber = 1.2 * previousNumber
        Console.WriteLine(previousNumber * 1.2);
        break;
    }
    previousNumber = number;
}