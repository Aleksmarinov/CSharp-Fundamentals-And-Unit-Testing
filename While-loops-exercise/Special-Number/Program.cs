int number = int.Parse(Console.ReadLine());
int startNumber = number; // първоначално въведеното число,което няма да се променя 

bool isSpecial = true;

// спираме: когато нямаме повече цифри -> number <= 0
// продължаваме: когато имаме налични цифри -> number > 0

while (number > 0)
{
    // 1. последна цифра
    int lastDigit = number % 10;
    // 2. проверка дали дели числото
    if (startNumber % lastDigit != 0)
    {
        // имаме цифра, която не дели числото -> не е специално
        isSpecial = false;
        break;
    }
    // 3. премахвам последната цифра
    number = number / 10; 
}

// 1. преминали сме през всички цифри -> всички цифри делят числото -> isSpecial = true;
// 2. имаме цифра, която не дели числото -> isSpecial = false;

if (isSpecial == true)
{
    Console.WriteLine(startNumber + " is special");
}
else
{
    Console.WriteLine(startNumber + " is not special");
}