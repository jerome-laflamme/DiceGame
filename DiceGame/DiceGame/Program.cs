using System.Runtime.CompilerServices;
using DiceLib;


namespace DiceGame // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            int guess = 0;

            Dice dice = new Dice();
            dice.SetFaceNumber();
            if (dice.FaceNumber == 0) Environment.Exit(0);
            dice.Throw();
            
            for (int i = 5; i > 0; i++)
            {
                if (i > 1 ) {
                    Console.WriteLine($"You have {i} tries left");
                    guess = Convert.ToInt32(Console.ReadLine());
                } else {
                    Console.WriteLine("Last try.. ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                
                if (guess == dice.DiceValue) {
                    Console.WriteLine("You win!");
                    break;
                }
                if (guess > dice.DiceValue) Console.Write("Number to guess is smaller.");
                if (guess < dice.DiceValue) Console.WriteLine("Number to guess is bigger.");
            }
        }
    }
}