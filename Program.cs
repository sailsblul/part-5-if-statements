using System;

namespace part_5_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 'stages' for Stages.");
            Console.WriteLine("Type 'hurricane' for Hurricane.");
            Console.WriteLine("Type 'dice' for Dice Game.");
            string choice = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("");
            if (choice == "stages")
            {
                Stages();
            }
            else if (choice == "hurricane")
            {
                Hurricane();
            }
            else if (choice == "dice")
            {
                DiceGame();
            }
            else
            {
                Console.WriteLine("That wasn't one of the options...");
            }
        }
        public static void Stages()
        {
            Console.WriteLine("input age:");
            bool isNum = int.TryParse(Console.ReadLine(), out int age);
            if (isNum)
            {
                if (age >= 18)
                {
                    Console.WriteLine("adult");
                }
                else if (age > 12)
                {
                    Console.WriteLine("teen");
                }
                else if (age > 10)
                {
                    Console.WriteLine("preteen");
                }
                else if (age > 5)
                {
                    Console.WriteLine("child");
                }
                else if (age <= 0)
                {
                    Console.WriteLine("toddler");
                }
                else
                {
                    Console.WriteLine("That's not how ages work...");
                }
            }
            else
            {
                Console.WriteLine("not a number.");
            }
        }
        public static void Hurricane()
        {
            Console.WriteLine("Input Hurricane Category:");
            int.TryParse(Console.ReadLine(), out int category);
            switch (category)
            {
                case 1:
                    Console.WriteLine("Hurricane speed in miles per hour: 74-95");
                    Console.WriteLine("Hurricane speed in kilometers per hour: 119-153");
                    Console.WriteLine("Hurricane speed in knots: 64-82");
                    break;
                case 2:
                    Console.WriteLine("Hurricane speed in miles per hour: 96-110");
                    Console.WriteLine("Hurricane speed in kilometers per hour: 154-177");
                    Console.WriteLine("Hurricane speed in knots: 83-95");
                    break;
                case 3:
                    Console.WriteLine("Hurricane speed in miles per hour: 111-130");
                    Console.WriteLine("Hurricane speed in kilometers per hour: 178-209");
                    Console.WriteLine("Hurricane speed in knots: 96-113");
                    break;
                case 4:
                    Console.WriteLine("Hurricane speed in miles per hour: 131-155");
                    Console.WriteLine("Hurricane speed in kilometers per hour: 210-249");
                    Console.WriteLine("Hurricane speed in knots: 114-135");
                    break;
                case 5:
                    Console.WriteLine("Hurricane speed in miles per hour: > 155");
                    Console.WriteLine("Hurricane speed in kilometers per hour: > 249");
                    Console.WriteLine("Hurricane speed in knots: > 135");
                    break;
                default:
                    Console.WriteLine("Error: Not a valid hurricane category.");
                    break;
                    
            }
        }
        public static void DiceGame()
        {
            double balance = 100;
            Random roll = new Random();
            Console.WriteLine("Which outcome would you like to bet on?");
            Console.WriteLine("Type 1 for Odd Sum.");
            Console.WriteLine("Type 2 for Even Sum.");
            Console.WriteLine("Type 3 for Doubles.");
            Console.WriteLine("Type 4 for Not Doubles.");
            int.TryParse(Console.ReadLine(), out int bet);
            Console.WriteLine($"You have ${balance}. How much do you want to bet?");
            double.TryParse(Console.ReadLine(), out double wager);
            int die1 = roll.Next(1, 7);
            int die2 = roll.Next(1, 7);
            Console.WriteLine("╔═════════╗ ╔═════════╗");
            if (die1 == 1)
            {
                Console.Write("║         ║ ");
            }
            else if (die1 < 4)
            {
                Console.Write("║       O ║ ");
            }
            else
            {
                Console.Write("║ O     O ║ ");
            }
            if (die2 == 1)
            {
                Console.WriteLine("║         ║");
            }
            else if (die2 < 4)
            {
                Console.WriteLine("║       O ║");
            }
            else
            {
                Console.WriteLine("║ O     O ║");
            }
            if (die1 == 6)
            {
                Console.Write("║ O     O ║ ");
            }
            else if (die1 % 2 == 1)
            {
                Console.Write("║    O    ║ ");
            }
            else
            {
                Console.Write("║         ║ ");
            }
            if (die2 == 6)
            {
                Console.WriteLine("║ O     O ║");
            }
            else if (die2 % 2 == 1)
            {
                Console.WriteLine("║    O    ║");
            }
            else
            {
                Console.WriteLine("║         ║");
            }
            if (die1 == 1)
            {
                Console.Write("║         ║ ");
            }
            else if (die1 < 4)
            {
                Console.Write("║ O       ║ ");
            }
            else
            {
                Console.Write("║ O     O ║ ");
            }
            if (die2 == 1)
            {
                Console.WriteLine("║         ║");
            }
            else if (die2 < 4)
            {
                Console.WriteLine("║ O       ║");
            }
            else
            {
                Console.WriteLine("║ O     O ║");
            }
            Console.WriteLine("╚═════════╝ ╚═════════╝");
            Console.WriteLine($"A {die1} and a {die2}!");
            switch (bet)
            {
                case 1:
                    Console.WriteLine($"That adds up to {die1 + die2}...");
                    if ((die1 + die2) % 2 == 1)
                    {
                        Console.WriteLine("You win!");
                        balance += wager;
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                        balance -= wager;
                    }
                    break;
                case 2:
                    Console.WriteLine($"That adds up to {die1 + die2}...");
                    if ((die1 + die2) % 2 == 0)
                    {
                        Console.WriteLine("You win!");
                        balance += wager;
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                        balance -= wager;
                    }
                    break;
                case 3:
                    if (die1 == die2)
                    {
                        Console.WriteLine("That's doubles...");
                        Console.WriteLine("You win!");
                        balance += 2 * wager;
                    }
                    else
                    {
                        Console.WriteLine("Not doubles...");
                        Console.WriteLine("You lose!");
                        balance -= wager;
                    }
                    break;
                case 4:
                    if (die1 == die2)
                    {
                        Console.WriteLine("That's doubles...");
                        Console.WriteLine("You lose!");
                        balance -= wager;
                    }
                    else
                    {
                        Console.WriteLine("Not doubles...");
                        Console.WriteLine("You win!");
                        balance += 1.5 * wager;
                    }
                    break;
                default:
                    Console.WriteLine("Unfortunately, you didn't follow the betting instructions, so this means nothing to you.");
                    break;
            }
            Console.WriteLine($"You now have ${Math.Round(balance, 2)}");
            //╔═════════╗
            //║ O     O ║ bullet points don't show up, have to use capital o for the dots and feel like a loser :/ 
            //║    O    ║  
            //║ O     O ║
            //╚═════════╝
        }
    }
}
