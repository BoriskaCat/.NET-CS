namespace ATMTests;

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ATM;

[TestFixture]
public class ATMTest
{
    [Test]
    public void GetAmountTest_correctInput()
    {
        using (var consoleInput = new StringReader("1\n"))
        {
            Console.SetIn(consoleInput);
            Assert.That(ATM.GetAmount(), Is.EqualTo(1L));
        }
    }

    [Test]
    public void GetAmountTest_invalidInput_0()
    {
        using (var consoleInput = new StringReader("0\n"))
        {
            Console.SetIn(consoleInput);
            ArithmeticException ex = Assert.Throws<ArithmeticException>(() => ATM.GetAmount());
            Assert.That(ex.Message, Is.EqualTo("Invalid value (0 or negative)"));
        }
    }

    [Test]
    public void GetAmountTest_invalidInput_negative()
    {
        using (var consoleInput = new StringReader("-1\n"))
        {
            Console.SetIn(consoleInput);
            ArithmeticException ex = Assert.Throws<ArithmeticException>(() => ATM.GetAmount());
            Assert.That(ex.Message, Is.EqualTo("Invalid value (0 or negative)"));
        }
    }

    [Test]
    public void GetAmountTest_emptyInput()
    {
        using (var consoleInput = new StringReader(""))
        {
            Console.SetIn(consoleInput);
            Exception ex = Assert.Throws<Exception>(() => ATM.GetAmount());
            Assert.That(ex.Message, Is.EqualTo("Nothing entered"));
        }
    }

    [Test]
    public void GetAmountTest_incorrectInput()
    {
        using (var consoleInput = new StringReader("areena"))
        {
            Console.SetIn(consoleInput);
            FormatException ex = Assert.Throws<FormatException>(() => ATM.GetAmount());
            Assert.That(ex.Message, Is.EqualTo("Amount entered incorrectly"));
        }
    }

    [Test]
    public void GetDenominationsTest_correctInput()
    {
        using (var consoleInput = new StringReader("1 2\n"))
        {
            Console.SetIn(consoleInput);
            Assert.That(ATM.GetDenominations(), Is.EqualTo(new List<long> { 2L, 1L }));
        }
    }

    [TestCase("0", "Invalid values (there are 0 or negative)")]
    [TestCase("-1 1", "Invalid values (there are 0 or negative)")]
    [TestCase("a b", "Invalid value")]
    public void GetDenominationsTest_NumberFormatException(string denomination, string expected)
    {
        using (var consoleInput = new StringReader(denomination))
        {
            Console.SetIn(consoleInput);
            FormatException e = Assert.Throws<FormatException>(() => ATM.GetDenominations());
            Assert.That(e.Message, Is.EqualTo(expected));
        }
    }

    [Test]
    public void GetDenominationsTest_newLineInput()
    {
        using (var consoleInput = new StringReader("\n"))
        {
            Console.SetIn(consoleInput);
            Exception ex = Assert.Throws<Exception>(() => ATM.GetDenominations());
            Assert.That(ex.Message, Is.EqualTo("Nothing entered"));
        }
    }

    [Test]
    public void GetDenominationsTest_emptyInput()
    {
        using (var consoleInput = new StringReader(""))
        {
            Console.SetIn(consoleInput);
            Exception ex = Assert.Throws<Exception>(() => ATM.GetDenominations());
            Assert.That(ex.Message, Is.EqualTo("Nothing entered"));
        }
    }

    [Test]
    public void GetAllCombinationsTest_5__3_2()
    {
        using (var consoleInput = new StringReader("5\n3 2\n"))
        {
            Console.SetIn(consoleInput);
            Assert.That(ATM.GetAllCombinations(5, new List<long> { 3L, 2L }), Is.EqualTo(1));
        }
    }

    [Test]
    public void GetAllCombinationsTest_4__2_1()
    {
        using (var consoleInput = new StringReader("4\n2 1\n"))
        {
            Console.SetIn(consoleInput);
            Assert.That(ATM.GetAllCombinations(4, new List<long> { 2L, 1L }), Is.EqualTo(3));
        }
    }

    [Test]
    public void GetAllCombinationsTest_4__1_2()
    {
        using (var consoleInput = new StringReader("4\n1 2\n"))
        {
            Console.SetIn(consoleInput);
            Assert.That(ATM.GetAllCombinations(4, new List<long> { 2L, 1L }), Is.EqualTo(3));
        }
    }

    [Test]
    public void GetAllCombinationsTest_1000__1()
    {
        using (var consoleInput = new StringReader("1000\n1\n"))
        {
            Console.SetIn(consoleInput);
            Assert.That(ATM.GetAllCombinations(1000, new List<long> { 1L }), Is.EqualTo(1));
        }
    }

    [Test]
    public void GetAllCombinationsTest_1000__500_1()
    {
        using (var consoleInput = new StringReader("1000\n500 1\n"))
        {
            Console.SetIn(consoleInput);
            Assert.That(ATM.GetAllCombinations(1000, new List<long> { 500L, 1L }), Is.EqualTo(3));
        }
    }

    [Test]
    public void GetAllCombinationsTest_5__10_6()
    {
        using (var consoleInput = new StringReader("5\n10 6\n"))
        {
            Console.SetIn(consoleInput);
            Assert.That(ATM.GetAllCombinations(5, new List<long> { 10L, 6L }), Is.EqualTo(0));
        }
    }

    [Test]
    public void GetAllCombinationsTest_3000000000__3000000000()
    {
        using (var consoleInput = new StringReader("3000000000\n3000000000\n"))
        {
            Console.SetIn(consoleInput);
            Assert.That(ATM.GetAllCombinations(3000000000L, new List<long> { 3000000000L }), Is.EqualTo(1));
        }
    }

    [Test]
    public void GetAllCombinationsTest_5__1_1()
    {
        using (var consoleInput = new StringReader("5\n1 1\n"))
        {
            Console.SetIn(consoleInput);
            Assert.That(ATM.GetAllCombinations(5, new List<long> { 1L }), Is.EqualTo(1));
        }
    }
}
