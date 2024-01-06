string product = Console.ReadLine();
int productQuantity = int.Parse(Console.ReadLine());

double result = CalculatePrice(product, productQuantity);

Console.WriteLine($"{result:F2}");

static double CalculatePrice(string product, int productQuantity)
{
    double result = 0;

    if (product == "coffee")
    {
        result = productQuantity * 1.5;
    }
    else if (product == "water")
    {
        result = productQuantity * 1.0;
    }
    else if (product == "coke")
    {
        result = productQuantity * 1.4;
    }
    else if (product == "snacks")
    {
        result = productQuantity * 2.0;
    }

    return result;
}