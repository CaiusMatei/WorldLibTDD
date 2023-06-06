using Microsoft.VisualStudio.TestTools.UnitTesting;

using WorldLib;

namespace WordLibTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void IsPalindrome()
    {
        // Create an instance to test:
        WorderTDD worder = new WorderTDD();

        // expected output
        string expectedResult = "radar";
        string inputWord = "radar";
        // Run the method under test:
        string actualResult = worder.IsPalindromeWordChecker(inputWord);

        // Assert / Verify the result:
        Assert.AreEqual(expectedResult, actualResult);


    }

    [TestMethod]

    public void IsPalindromeThrows()
    {
        // Create an instance to test:
        WorderTDD worder = new WorderTDD();

        // expected output
        string inputWord = null;

        // Assert / Verify the result:
        Assert.ThrowsException<ArgumentException>(() => worder.IsPalindromeWordChecker(inputWord));


    }

    [TestMethod]

    public void StringLenght()
    {
        // Create an instance to test:
        WorderTDD worder = new WorderTDD();

        // expected output
        int expectedOutput = 9;
        string inputWord = "Stockholm";

        // Run the method under test:
        int actualResult = worder.CheckingStringLength(inputWord);
        // Assert / Verify the result:
        Assert.AreEqual(expectedOutput, actualResult);


    }

    [TestMethod]

    public void StringLenghtCheckThrows()
    {
        // Create an instance to test:
        WorderTDD worder = new WorderTDD();

        // expected output
        string inputWord = null;

        // Assert / Verify the result:
        Assert.ThrowsException<ArgumentException>(() => worder.CheckingStringLength(inputWord));


    }





}

