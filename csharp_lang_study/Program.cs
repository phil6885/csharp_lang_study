Console.WriteLine("Hello Main!");
var stock = new Stock();
Console.WriteLine($"current price from main: {stock.CurrentPrice}");

public class Stock
{
    public decimal CurrentPrice { get; } = 123;
}