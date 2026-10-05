Console.WriteLine("Hello Main!");
var stock = new Stock
{
    CurrentPrice = 100
};
Console.WriteLine($"current price from main: {stock.CurrentPrice}");

public class Stock
{
    public decimal CurrentPrice { get; set; }
}