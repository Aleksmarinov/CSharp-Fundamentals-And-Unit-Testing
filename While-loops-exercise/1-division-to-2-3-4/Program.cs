﻿int countNumbers = int.Parse(Console.ReadLine());

int count2 = 0; // брой на числата, които се делят на 2
int count3 = 0; // брой на числата, които се делят на 3
int count4 = 0; // брой на числата, които се делят на 4

int numbers = 1;

while(numbers <= countNumbers)
{
    numbers++;
    int value = int.Parse(Console.ReadLine());

    if (value % 2 == 0)
    {
        count2++;
    }
    if (value % 3 == 0)
    {
        count3++;
    }
    if (value % 4 == 0)
    {
        count4++;
    }
}

double percent2 = count2 * 1.0 / countNumbers * 100;
double percent3 = count3 * 1.0 / countNumbers * 100;
double percent4 = count4 * 1.0 / countNumbers * 100;

Console.WriteLine($"{percent2:F2}%");
Console.WriteLine($"{percent3:F2}%");
Console.WriteLine($"{percent4:F2}%");