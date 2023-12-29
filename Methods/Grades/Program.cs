static void GradeInWords(double gradeParameter)
{
    if (gradeParameter >= 2 && gradeParameter < 3)
    {
        Console.WriteLine("Fail");
    }
    else if (gradeParameter >= 3 && gradeParameter < 3.5)
        {
        Console.WriteLine("Average");
    }
    else if (gradeParameter >= 3.5 && gradeParameter < 4.5)
    {
        Console.WriteLine("Good");
    }
    else if (gradeParameter >= 4.5 && gradeParameter < 5.5)
    {
        Console.WriteLine("Very good");
    }
    else
    {
        Console.WriteLine("Excellent");
    }
}

double gradeFromUser = double.Parse(Console.ReadLine());

GradeInWords(gradeFromUser);
