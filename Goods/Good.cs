namespace Goods;

public abstract class Good
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Type { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    protected Good(int id, string brand, string type, int quantity, double price)
    {
        this.Id = id;
        this.Brand = brand;
        this.Type = type;
        this.Quantity = quantity;
        this.Price = price;
    }

    public void checkQuantity()
    {
        if (this.Quantity <= 5)
        {
            Console.WriteLine($"Товара {Brand} {Type} осталось {Quantity}, пожалуйста закажите ещё");
        }
        else
        {
            Console.WriteLine($"Товара {Brand} {Type} осталось {Quantity}, пока достаточно, можно не заказывать");
        }
    }

    public abstract void PrintInfo();
}