int daysBeforeExam = int.Parse(Console.ReadLine());

while (daysBeforeExam > 0)
{
    Console.WriteLine($"{daysBeforeExam} days before the exam");
    daysBeforeExam--;
}
Console.WriteLine("The exam has come");