
namespace DiceLib;


public class Dice
{
    public int FaceNumber { get; private set; }
    public int DiceValue { get; set; }

    public Dice()
    {
        FaceNumber = SetFaceNumber();
        DiceValue = 1;
    }

    public int SetFaceNumber()
    {
        Console.WriteLine("What dice do you want to roll? " +
                          "\n1 - 2 faces" +
                          "\n2 - 6 faces" +
                          "\n3 - 20 faces" +
                          "\n4 - Custom" +
                          "\n5 - Cancel");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                return 2;
            case 2:
                return 6;
            case 3:
                return 20;
            case 4:
                Console.Write("How many faces do you want your dice to be? (2-120)  ");
                int CustomDice = int.Parse(Console.ReadLine());
                return CustomDice;
            default:
                return 0;
        }
    }
    public void Throw()
    {
        Console.WriteLine("ROLLING! Guess what's the number? ");

        Random rnd = new Random();
        DiceValue =  rnd.Next(1, FaceNumber);
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        if (FaceNumber != 6) return Convert.ToString(DiceValue);
        if (FaceNumber == 6)
        {
            string[] unicode =
            {
                "\u2680",
                "\u2681",
                "\u2682",
                "\u2683",
                "\u2684",
                "\u2685"
            };
            return unicode[DiceValue];
        }
        return base.ToString();
    }
}