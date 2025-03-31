namespace Shopping.Model;

public class Basket
{
    private Item _item;
    public double Total => _item is null? 0.0 : 100.0;

    public void Add(Item item)
    {
        _item = item;
    }
}