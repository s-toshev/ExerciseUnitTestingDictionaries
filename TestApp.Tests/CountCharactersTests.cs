using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string actual = CountCharacters.Count(input);
        string expected = string.Empty;
        // Assert
        Assert.AreEqual(expected, actual);

    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "" };

        // Act
        string actual = CountCharacters.Count(input);
        string expected = string.Empty;
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "N" };

        // Act
        string actual = CountCharacters.Count(input);
        string expected = "N -> 1";
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "N", "Naomi","imoaN" };

        // Act
        string actual = CountCharacters.Count(input);
        string expected = "N -> 3\r\na -> 2\r\no -> 2\r\nm -> 2\r\ni -> 2";
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "N%%%%mi", "MIX***" };

        // Act
        string actual = CountCharacters.Count(input);
        string expected = "N -> 1\r\n% -> 4\r\nm -> 1\r\ni -> 1\r\nM -> 1\r\nI -> 1\r\nX -> 1\r\n* -> 3";
        // Assert
        Assert.AreEqual(expected, actual);
    }
}
