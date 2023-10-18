using System.Collections.Generic;

public interface IWin
{
    enum Colors
    {
        Red,
        Green,
        White
    }
    bool isWinner(List<Ball> balls);
}
