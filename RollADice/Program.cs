using System;

namespace RollADice
{
    class Program
    {
        static void Main(string[] args)
        {
            UtilDiceRollingClass rollStuff = new UtilDiceRollingClass();
            bool loop = true;
            while (loop)
            {
                ConsoleKey key = new ConsoleKey();
                int diceType = 0;
                int modifier = -1;
                int numberOfTrials = 0;
                while (diceType == 0)
                {
                    diceType = rollStuff.diceTypePrompt();
                }
                while(numberOfTrials <= 0)
                {
                    numberOfTrials = rollStuff.chooseNumberOfTrials();
                }
                while (modifier == -1)
                {
                    modifier = rollStuff.chooseModifier();
                }
                rollStuff.roll(diceType, numberOfTrials, modifier);

                Console.WriteLine("\n press Backspace to exit or space to continue");
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Backspace:
                        loop = false;
                        break;
                    case ConsoleKey.Spacebar:
                    default:
                        loop = true;
                        break;
                }
            }
        }
        
    }
}
