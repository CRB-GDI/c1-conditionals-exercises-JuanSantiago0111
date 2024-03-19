using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doorLocked = true;
            int triesLeft = 3;
            const string correctPassword = "oP3nSesaME!";

            Console.WriteLine("You are standing in front of a locked door.  There is a sign that says, you must provide the correct password to enter.");
            
            // Loop until the door is unloced or the player has tried 3 times.
            while (doorLocked && triesLeft > 0 )
            {
                // Decrement the number of tries remaining
                triesLeft--;

                // Do Not change code above this line.  Add your code below

                // Add code to prompt for and get user's password.
                Console.Write("Enter the password of the dooor!");

                string response = Console.ReadLine();
                
                if (response == correctPassword)
                {
                    Console.WriteLine("you have been granted entry");
                    doorLocked = false;
                }

                else if (response !=  correctPassword && response != "")
                {
                    Console.WriteLine("nope!");
                }
                else
                {
                    Console.WriteLine("You must enter something");
                }


                //Check if the password is correct or not
               






                // Do not change code below this line

            }
        }
    }
}
