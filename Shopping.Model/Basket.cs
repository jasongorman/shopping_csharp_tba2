namespace Shopping.Model;

public class Basket
{
    private readonly List<Item> _items = new();
    public double Total => _items.Sum(item => item.Price);

    public void Add(Item item)
    {
        _items.Add(item);
    }
}