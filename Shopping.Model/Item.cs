namespace Shopping.Model;

public class Item
{
    public double Price { get; }

    public Item(int quantity, double price)
    {
        Price = price;
    }
}