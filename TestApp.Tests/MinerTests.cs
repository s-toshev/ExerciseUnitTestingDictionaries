using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>(); 
        // Act
        string actual = Miner.Mine(input);
        string expected = string.Empty;
        // Assert
        Assert.AreEqual(expected, actual);
         
    }
        // TODO: finish test
        [Test]
        public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
        {
        // Arrange
        string[] input = {"GolD 26", "goLd 14","silver 15","silveR 15" };
        // Act
        string actual = Miner.Mine(input);
        string expected = "gold -> 40\r\nsilver -> 30";
        // Assert
        Assert.AreEqual(expected, actual);
    }

        [Test]
        public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
        {
        // Arrange
        string[] input = { "iron 33", "Gold 26", "gold 14", "silver 15", "silver 15", "copper 18" };
        // Act
        string actual = Miner.Mine(input);
        string expected = "iron -> 33\r\ngold -> 40\r\nsilver -> 30\r\ncopper -> 18";
        // Assert
        Assert.AreEqual(expected, actual);

    }
    }
