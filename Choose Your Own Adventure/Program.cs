using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random randomObject = new Random();
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It's work day at MCCTC Tech Dept. You're currently in the office fixing a computer. You hear adult ed call you on the radio, do you pick up?");
            Console.Write("Type yes or no: ");
            string noiseChoice = Console.ReadLine().ToUpper();
            if (noiseChoice == "YES")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You pick up the radio and report back and ask what they need. They say there are issues in room G-02. (A computer issue).\n\nYou reach G-02, do you knock or just open the door?");
                string doorChoice = Console.ReadLine().ToUpper();
                if (doorChoice == "KNOCK")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You knock on the door, and the door opens. The adult ed teacher shows you the computer than isn't working. Should you try to troubleshoot by opening the computer or restarting it?");
                    string tOrRChoice = Console.ReadLine().ToUpper();
                    if (tOrRChoice == "TROUBLESHOOT")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You wasted 30 mins of your time to fix it, you could've just shut off and on again. THE END.");
                    }
                    else if (tOrRChoice == "RESTART")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congrats! You solved the issue under 1 minute. the end.");
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You just sit there staring doing nothing, nice."); }

                }
                else if (doorChoice == "OPEN")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Everyone stares at you for 30 seconds for being rude. You get to the PC that needs to be fixed your minds rolls 3 choices of what to do.");
                    int randomRoll = randomObject.Next(3);
                    switch (randomRoll)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Your mind chose to check the PC Compenents. You wasted 30 mins. the end.");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("You chose to shut the PC off and on and it works! The power of restarting is powerful! The end");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("You kicked the PC around hoping it will work, you paid $1,200 for damages. The end.");
                            break;

                    }
                }
            }
            else if (noiseChoice == "NO")
            {
                Console.WriteLine("Ahh, the typical. Gotcha. Have a good one.");
                System.Environment.Exit(1);
            }
        }
    }
}



