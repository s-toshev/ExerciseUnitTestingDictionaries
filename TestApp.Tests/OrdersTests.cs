using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        // Act
        string expected = string.Empty;
        string actual = Orders.Order(input);

        // Assert
        Assert.AreEqual(expected, actual);

    }
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange

        string[] input = new string[]
{
    "Apple 0.50 2",   // Product: Apple, Price: $0.50, Quantity: 2
    "Banana 0.30 3",  // Product: Banana, Price: $0.30, Quantity: 3
    "Orange 0.70 1",  // Product: Orange, Price: $0.70, Quantity: 1
    "Mango 1.20 2"    // Product: Mango, Price: $1.20, Quantity: 2
};
        // Act
        string actual = Orders.Order(input);
        string expected = "Apple -> 1.00\r\nBanana -> 0.90\r\nOrange -> 0.70\r\nMango -> 2.40";

        // Assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange

        string[] input = new string[]
{
    "Apple 2 2",   // Product: Apple, Price: $0.50, Quantity: 2
    "Banana 1 3",  // Product: Banana, Price: $0.30, Quantity: 3
    "Orange 5 1",  // Product: Orange, Price: $0.70, Quantity: 1
    "Mango 11 2"    // Product: Mango, Price: $1.20, Quantity: 2
};
        // Act
        string actual = Orders.Order(input);
        string expected = "Apple -> 4.00\r\nBanana -> 3.00\r\nOrange -> 5.00\r\nMango -> 22.00";

        // Assert

        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange

        string[] input = new string[]
{
    "Apple 0.50 2.5",   // Product: Apple, Price: $0.50, Quantity: 2
    "Banana 0.30 3.2",  // Product: Banana, Price: $0.30, Quantity: 3
    "Orange 0.70 1.1",  // Product: Orange, Price: $0.70, Quantity: 1
    "Mango 1.20 2.7"    // Product: Mango, Price: $1.20, Quantity: 2
};
        // Act
        string actual = Orders.Order(input);
        string expected = "Apple -> 1.25\r\nBanana -> 0.96\r\nOrange -> 0.77\r\nMango -> 3.24";

        // Assert

        Assert.AreEqual(expected, actual);
    }
}
