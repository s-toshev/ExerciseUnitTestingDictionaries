using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] arr = Array.Empty<string>();

        // Act
        string actual = Plants.GetFastestGrowing(arr);
        string expected = string.Empty;

        // Assert    
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] arr = { "Banana" };

        // Act
        string actual = Plants.GetFastestGrowing(arr);
        string expected = "Plants with 6 letters:\r\nBanana";

        // Assert    
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] arr = { "Banana", "Orange", "Kiwi" };

        // Act
        string actual = Plants.GetFastestGrowing(arr);
        string expected = "Plants with 4 letters:\r\nKiwi\r\nPlants with 6 letters:\r\nBanana\r\nOrange";

        // Assert    
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] arr = { "BaNana", "OrANge", "KiWi","RosE" };

        // Act
        string actual = Plants.GetFastestGrowing(arr);
        string expected = "Plants with 4 letters:\r\nKiwi\r\nRose\r\nPlants with 6 letters:\r\nBanana\r\nOrange";

        // Assert    
        Assert.AreEqual(expected, actual);
    }
}
