Console.WriteLine("Hello Main!");
var stock = new Stock() { CurrentPrice = 999 };
Console.WriteLine($"current price from main: {stock.CurrentPrice}");

public class Stock
{
    public decimal CurrentPrice { get; init; } = 123;
}