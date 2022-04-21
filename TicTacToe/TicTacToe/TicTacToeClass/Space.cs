namespace TicTacToeClass;

public class Space
{
    public bool IsEmpty { get; set; }
    public char SpaceValue { get; set; }
    public int SpaceNumber { get; set; }
    public int NextSpace { get; set; }

    public Space(char spaceValue, int spaceNumber)
    {
        IsEmpty = true;
        SpaceValue = spaceValue;
        SpaceNumber = NextSpace;
        NextSpace++;
    }
}