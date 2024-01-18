using System;
using System.Collections.Generic;
using Mission1Assignment;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceSimulator diceSimulator = new DiceSimulator();
        List<int> results = diceSimulator.SimulateRolls(numberOfRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

        int totalRolls = 0;
        foreach (var result in results)
        {
            totalRolls += result;
        }

        Console.WriteLine($"Total number of rolls = {totalRolls}.");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / totalRolls;
            int asterisksCount = (percentage * numberOfRolls) / 100;
            string histogram = new string('*', asterisksCount);
            Console.WriteLine($"{i}: {histogram}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}
