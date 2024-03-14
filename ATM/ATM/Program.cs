namespace ATM;

using System;
using System.Collections.Generic;
using System.Linq;

public class ATM
{
    /**
        * Receiving the exchange amount from the user.
   */
    public static long GetAmount()
    {
        Console.WriteLine("# Exchange amount:");
        long amount;
        try
        {
            amount = long.Parse(Console.ReadLine());
        }
        catch (ArgumentNullException)
        {
            throw new Exception("Nothing entered");
        }
        catch (FormatException)
        {
            throw new FormatException("Amount entered incorrectly");
        }
        catch (OverflowException)
        {
            throw new OverflowException("Amount entered is too large");
        }
        if (amount <= 0)
        {
            throw new ArithmeticException("Invalid value (0 or negative)");
        }
        return amount;
    }

    /**
        * Receiving available denominations for exchange from the user. The array of entered values is
        * sorted.
    */
    public static List<long> GetDenominations()
    {
        Console.WriteLine("# Available denominations:");
        string userInput;
        try
        {
            userInput = Console.ReadLine();
        }
        catch (Exception)
        {
            throw new Exception("Input Error");
        }

        if (string.IsNullOrEmpty(userInput))
        {
            throw new Exception("Nothing entered");
        }

        List<long> listOfDenominations;
        try
        {
            listOfDenominations = userInput.Trim().Split(' ')
                .Select(long.Parse).OrderByDescending(x => x).Distinct().ToList();
        }
        catch (FormatException)
        {
            throw new FormatException("Invalid value");
        }

        if (listOfDenominations.Last() <= 0)
        {
            throw new FormatException("Invalid values (there are 0 or negative)");
        }

        return listOfDenominations;
    }

    /**
        * Combination generation function that returns the total number of combinations. The newly
        * created combination is printed.
    */
    public static long GetAllCombinations(long sum, List<long> denominations)
    {
        return ExchangeCombinations(sum, denominations,
            new long[denominations.Count],
            0);
    }

    /**
        * Main component of getAllCombinations function.
        *
        * @param denominationQuantity Array of numbers of each denomination in combination.
        * @param denominationIndex    Index of denomination with which the calculation is made.
    */
    private static long ExchangeCombinations(long amount, List<long> denominations,
        long[] denominationQuantity,
        int denominationIndex)
    {
        int numberOfDenominations = denominations.Count;
        long value;
        long numberOfCombinations = 0;

        if (denominationIndex == numberOfDenominations - 1)
        {
            if (amount % denominations[denominationIndex] == 0)
            {
                numberOfCombinations = 1;
                denominationQuantity[denominationIndex] = amount / denominations[denominationIndex];
                PrintCombination(denominations, denominationQuantity);
            }
        }
        else
        {
            long l = amount / denominations[denominationIndex];
            for (long i = l; i >= 0; i--)
            {
                value = amount - i * denominations[denominationIndex];
                denominationQuantity[denominationIndex] = i;
                numberOfCombinations += ExchangeCombinations(value, denominations,
                    denominationQuantity,
                    denominationIndex + 1);
            }
        }

        return numberOfCombinations;
    }

    /**
        * Combination output.
    */
    public static void PrintCombination(List<long> denominations,
        long[] distributionOfDenominations)
    {
        Console.WriteLine("Combination start");
        for (int i = 0; i < denominations.Count; i++)
        {
            for (int j = 0; j < distributionOfDenominations[i]; j++)
            {
                Console.WriteLine(denominations[i].ToString());
            }
        }
        Console.WriteLine("Combination end");
    }

    /**
        * Main executive function.
    */
    public static void Main(string[] args)
    {
        try
        {
            long amount = GetAmount();
            List<long> denominations = GetDenominations();
            long numberOfCombinations = GetAllCombinations(amount, denominations);
            Console.WriteLine("# Number of combinations " + numberOfCombinations.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
