namespace Shopping.Test;

public class Basket
{
    private List<Item> _items;
    
    public double Total => _items.Sum(item => item.Subtotal());

    public Basket()
    {
        _items = new List<Item>();
    }

    public void Add(Item item)
    {
        _items.Add(item);
    }
}