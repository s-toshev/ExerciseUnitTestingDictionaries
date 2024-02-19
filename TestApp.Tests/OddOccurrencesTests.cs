using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] strings = Array.Empty<string>();

        //Act
        string actual = OddOccurrences.FindOdd(strings);    
        string expected = string.Empty;

        //Assert
        Assert.AreEqual(expected, actual);


    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        //Arrange
        string[] strings = new string[] { };

        //Act
        string actual = OddOccurrences.FindOdd(strings);
        string expected = string.Empty;

        //Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        //Arrange
        string[] strings = new string[] { "Naomi" };

        //Act
        string actual = OddOccurrences.FindOdd(strings);
        string expected = "naomi";

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        //Arrange
        string[] strings = new string[] { "Naomi", "mix", "mix", "Naomi", "Naomi", "Imoan", "mix", "Imoan" };

        //Act
        string actual = OddOccurrences.FindOdd(strings);
        string expected = "naomi mix";

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        //Arrange
        string[] strings = new string[] { "NaOMi", "mIx", "Mix", "naomI", "Naomi", "ImoaN", "mix", "ImoAN" };

        //Act
        string actual = OddOccurrences.FindOdd(strings);
        string expected = "naomi mix";

        //Assert
        Assert.AreEqual(expected, actual);
    }

}

