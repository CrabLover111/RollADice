using System;


namespace RollADice
{
    class UtilDiceRollingClass
    {
        int diceType;
        public int diceTypePrompt()
        {
            Console.WriteLine("Choose a dice (1 = d4, 2 = d6, 3 = d8, 4 = d10, 5 = d12, 6 = d20 \n");
            ConsoleKey consoleKey = Console.ReadKey().Key;

            switch (consoleKey)
            {

                case ConsoleKey.D1:
                    diceType = 5;
                    break;
                case ConsoleKey.D2:
                    diceType = 7;
                    break;
                case ConsoleKey.D3:
                    diceType = 9;
                    break;
                case ConsoleKey.D4:
                    diceType = 11;
                    break;
                case ConsoleKey.D5:
                    diceType = 13;
                    break;
                case ConsoleKey.D6:
                    diceType = 21;
                    break;
                default:
                    Console.WriteLine("\nenter correct key");
                    break;
            }
            return diceType;
        }

        public int chooseNumberOfTrials()
        {
            Console.WriteLine("\nwrite integer number if trials");

                string possiblyWrongInput = Console.ReadLine();
                int numberOfTrials;
                int.TryParse(possiblyWrongInput, out numberOfTrials);
            return numberOfTrials;
        }

        public int chooseModifier()
        {
            Console.WriteLine("\nwrite integer modifier");
            string possiblyWrongInput = Console.ReadLine();
            int modifier;
            int.TryParse(possiblyWrongInput, out modifier);
            return modifier;
        }
        public void roll(int diceType, int numberOfTrials, int modifier)
        {
            Random rand = new Random();

            for(int i = 0; i < numberOfTrials; i++)
            {
                int random = rand.Next(1, diceType);
                Console.WriteLine("\n");
                Console.WriteLine(random + modifier + " (" + random + " " + "+ " + modifier + ")" );
                
            }
        }
    }
}