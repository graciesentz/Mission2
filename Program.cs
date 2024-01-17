using Mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        int numRolls = int.Parse(Console.ReadLine());

        DiceRoller diceRoller = new DiceRoller();

        int[] results = diceRoller.SimulateRolls(numRolls);

        PrintHistogram(results, numRolls);

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }

    static void PrintHistogram(int[] results, int totalRolls)
    {
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.\n");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / totalRolls;
            Console.WriteLine($"{i}: {new string('*', percentage)}");
        }
    }
}
