char firstLetter = char.Parse(Console.ReadLine());
char lastLetter = char.Parse(Console.ReadLine());

while (firstLetter <= lastLetter)
{
    Console.Write(firstLetter + " ");
    firstLetter++;
}