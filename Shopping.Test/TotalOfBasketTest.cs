using NUnit.Framework;

namespace Shopping.Test;

[TestFixture]
public class TotalOfBasketTest
{
    [Test]
    public void TotalOfEmptyBasket()
    {
        var basket = new Basket();
        Assert.That(basket.Total, Is.EqualTo(0.0));
    }

    [Test]
    public void TotalOfOneItem()
    {
        var basket = new Basket();
        basket.Add(new Item(1, 100.0));
        
        Assert.That(basket.Total, Is.EqualTo(100.0));
    }

    [Test]
    public void TotalOfTwoItems()
    {
        var basket = new Basket();
        basket.Add(new Item(1, 10.0));
        basket.Add(new Item(1, 50));
        Assert.That(basket.Total, Is.EqualTo(60.0));
    }

    [Test]
    public void TotalOfOneItemWithQuantityOfTwo()
    {
        var basket = new Basket();
        basket.Add(new Item(2, 100.0));
        
        Assert.That(basket.Total, Is.EqualTo(200.0));
    }
}