using NUnit.Framework;
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
}