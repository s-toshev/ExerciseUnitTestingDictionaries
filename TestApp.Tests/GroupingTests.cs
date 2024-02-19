using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> list = new List<int>() { };
        // Act
        string expected = string.Empty;
        string actual = Grouping.GroupNumbers(list);
        // Assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { 3, 5, 67, 8, 9, 15 };
        // Act
        string expected = "Odd numbers: 3, 5, 67, 9, 15\r\nEven numbers: 8";
        string actual = Grouping.GroupNumbers(list);
        // Assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { 88, 2, 16, 34 };
        // Act
        string expected = "Even numbers: 88, 2, 16, 34";
        string actual = Grouping.GroupNumbers(list);
        // Assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { 3, 5, 9, 15 };
        // Act
        string expected = "Odd numbers: 3, 5, 9, 15";
        string actual = Grouping.GroupNumbers(list);
        // Assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { -12,-3, -5, -67, -8, -9, -16 };
        // Act
        string expected = "Even numbers: -12, -8, -16\r\nOdd numbers: -3, -5, -67, -9";
        string actual = Grouping.GroupNumbers(list);
        // Assert

        Assert.AreEqual(expected, actual);
    }
}
