public class Stock
{
    decimal currentPrice;

    public decimal CurrentPrice
    {
        get
        {
            Console.WriteLine($"get current price: {currentPrice}");
            return currentPrice;
        }
        set
        {
            Console.WriteLine($"Set current price: {value}");
            currentPrice = value;
        }
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello Main!");
        var stock = new Stock
        {
            CurrentPrice = 100
        };
        Console.WriteLine($"current price from main: {stock.CurrentPrice}");
    }
}