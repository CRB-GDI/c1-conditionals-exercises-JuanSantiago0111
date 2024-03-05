using System.Reflection.Metadata;

namespace Exercise5;
/// <summary>
/// Akhtar Revisited
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        
        // Instantiate a random number generator (RNG)
        Random random = new Random();
        
        // Declare variable for dice roll and the value to a random # betwen 1 & 6 (inclusive)
        int diceRoll = random.Next(1, 7);
        Console.WriteLine(diceRoll);
        if (diceRoll % 2 == 0)
        {
            Console.WriteLine("You attack");
        }
        else
        {
            Console.WriteLine("You run away");
        }
    }
}