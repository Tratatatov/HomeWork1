using System.Collections.Generic;

public class AllBalls : IWin
{
    private List<Ball> _balls;
    public AllBalls(List<Ball> balls)
    {
        _balls = balls;
    }

    public bool isWinner(List<Ball> balls)
    {
        if (balls.Exists(ball => balls.Contains(ball)))
            return false;
        else return true;
    }
}
