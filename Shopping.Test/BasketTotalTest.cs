using NUnit.Framework;
using NUnit.Framework.Constraints;
using Shopping.Model;

namespace Shopping.Test;

public class BasketTotalTest
{
    [Test]
    public void TotalOfEmptyBasket()
    {
        Basket basket = new Basket();
        Assert.That(basket.Total, Is.EqualTo(0.0));
    }

    [Test]
    public void TotalOfSingleItem()
    {
        Basket basket = new Basket();
        basket.Add(new Item(1, 100.0));
        Assert.That(basket.Total, Is.EqualTo(100.0));
    }
}