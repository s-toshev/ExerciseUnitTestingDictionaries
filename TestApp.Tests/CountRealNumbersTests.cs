using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = Array.Empty<int>();   
        // Act
        string expected = string.Empty;
        string actual = CountRealNumbers.Count(input);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 3 };
        // Act
        string expected = "3 -> 1";
        string actual = CountRealNumbers.Count(input);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 3,5,5,5,8,7,7 };
        // Act
        string expected = "3 -> 1\r\n5 -> 3\r\n7 -> 2\r\n8 -> 1";
        string actual = CountRealNumbers.Count(input);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { -3, -35, -35, -135, -8, -7,-7 };
        // Act
        string expected = "-135 -> 1\r\n-35 -> 2\r\n-8 -> 1\r\n-7 -> 2\r\n-3 -> 1";
        string actual = CountRealNumbers.Count(input);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 0 };
        // Act
        string expected = "0 -> 1";
        string actual = CountRealNumbers.Count(input);
        // Assert
        Assert.AreEqual(expected, actual);
    }
}
