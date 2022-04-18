using System.Runtime.CompilerServices;
using DiceLib;


namespace DiceGame
{
    internal class Program
    {
        static void Main()
        {
            int guess = 0;

            Dice dice = new Dice();
            if (dice.FaceNumber == 0) Environment.Exit(0);
            dice.Throw();
            for (int i = 5; i >= 0; i--)
            {
                if (i > 1)
                {
                    Console.WriteLine($"You have {i} tries left");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (i == 1)
                {
                    Console.WriteLine("Last try.. ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You Lose!");
                }

                if (guess == dice.DiceValue) { Console.WriteLine("You win!"); break; }
                if (guess > dice.DiceValue) Console.Write("Number to guess is smaller.");
                if (guess < dice.DiceValue) Console.WriteLine("Number to guess is bigger.");
            }
        }
    }
}