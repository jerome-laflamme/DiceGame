using System.Runtime.CompilerServices;
using DiceLib;


namespace DiceGame
{
    internal class PartieB
    {
        static void Main()
        {
            Dice[] diceArray = new Dice[5];
            for (int i = 0; i < diceArray.Length; i++)
            {
                diceArray[i] = new Dice();
            }

            foreach (Dice dice in diceArray)
            {
                dice.Throw();
                Console.WriteLine(dice.ToString());
            }

            /*List<Dice> diceList = new List<Dice>();
            for (int i = 0; i < 5; i++)
            {
                diceList.Add(new Dice());
            }

            foreach (var dice in diceList)
            {
                Console.WriteLine(dice);
            }*/
        }
    }
}