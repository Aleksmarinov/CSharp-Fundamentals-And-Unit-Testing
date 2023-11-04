namespace _03.New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double cost = 0;

            switch (flowersType)
            {
                case "Roses":
                    cost = flowersCount * 5;
                    if (flowersCount > 80)
                    {
                        cost = cost * 0.9;
                    }
                    break;
                case "Dahlias":
                    cost = flowersCount * 3.8;
                    if (flowersCount > 90)
                    {
                        cost = cost * 0.85;
                    }
                    break;
                case "Tulips":
                    cost = flowersCount * 2.8;
                    if (flowersCount > 80)
                    {
                        cost = cost * 0.85;
                    }
                    break;
                case "Narcissus":
                    cost = flowersCount * 3;
                    if (flowersCount < 120)
                    {
                        cost = cost * 1.15;
                    }
                    break;
                case "Gladiolus":
                    cost = flowersCount * 2.5;
                    if (flowersCount < 80)
                    {
                        cost = cost * 1.2;
                    }
                    break;
            }
            if (budget < cost)
            {
                Console.WriteLine($"Not enough money, you need {(cost - budget):f2} leva more.");
            } else
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {(budget - cost):f2} leva left.");
            }
        }
    }
}
