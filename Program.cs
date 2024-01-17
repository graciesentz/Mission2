using Mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        // ask how many rolls the user wants
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        // get the number of rolls from user input
        int numRolls = int.Parse(Console.ReadLine());

        // create instance of the class
        DiceRoller diceRoller = new DiceRoller();

        // store results in results array
        int[] results = diceRoller.SimulateRolls(numRolls);

        PrintHistogram(results, numRolls);

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }

    //print the histogram
    static void PrintHistogram(int[] results, int totalRolls)
    {
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.\n");

        // print the stars based on the results
        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / totalRolls;
            Console.WriteLine($"{i}: {new string('*', percentage)}");
        }
    }
}
