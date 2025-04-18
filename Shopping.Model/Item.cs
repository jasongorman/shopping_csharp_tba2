﻿namespace Shopping.Model;

public class Item
{
    private int Quantity { get; }
    private double Price { get; }

    public Item(int quantity, double price)
    {
        Quantity = quantity;
        Price = price;
    }

    public double Subtotal()
    {
        return Price * Quantity;
    }
}