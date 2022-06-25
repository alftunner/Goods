namespace Goods;

public class HouseholdChemical : Good
{
    public int Volume { get; set; }
    public DateTime Term { get; set; }

    public HouseholdChemical(int id, string brand, string type, int quantity, double price, int volume, DateTime term) : base(id, brand, type, quantity, price)
    {
        this.Volume = volume;
        this.Term = term;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Volume: {Volume}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Term: {Term}");
        Console.WriteLine("-----------------");
    }
}