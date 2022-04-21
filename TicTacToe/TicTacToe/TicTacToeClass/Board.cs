using System.Threading.Channels;

namespace TicTacToeClass;

public class Board
{
    public static Space space { get; set; }
    public static void PrintBoard()
    {
        Console.WriteLine($"| {spacePrint()} | {spacePrint()} | {spacePrint()} | ");
        Console.WriteLine("----------------");
        Console.WriteLine($"| {spacePrint()} | {spacePrint()} | {spacePrint()} | ");
        Console.WriteLine("----------------");
        Console.WriteLine($"| {spacePrint()} | {spacePrint()} | {spacePrint()} | ");
    }

    public static string spacePrint()
    {
        if (space.IsEmpty) return Convert.ToString(space.SpaceNumber + 1);
        return Convert.ToString(space.SpaceValue);
    }

    public void Move()
    {
        int spaceSelect;
        
        Console.Write("Where do you want to play? "); 
        spaceSelect = int.Parse(Console.ReadLine());
        
        while (space[spaceSelect - 1].isEmpty == false)
        {
            Console.Write("This space is not empty. Try again.  ");
            spaceSelect = int.Parse(Console.ReadLine());
        }

        space[spaceSelect - 1].SpaceValue = 'X';
        PrintBoard();
    }
}