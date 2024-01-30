double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
int[] arrays = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    arrays[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
    Console.WriteLine($"{numbers[i]} => {arrays[i]}");
}
