using System.Collections.Generic;

public class WinOneColor : IWin
{
    private List<Ball> _balls;

    public WinOneColor(List<Ball> balls)
    {
        _balls = balls;
    }
    public bool isWinner(List<Ball> balls)
    {
        if (balls.Exists(redBall => redBall.ColorOfTheBall == Ball.BallColor.Red) &&
            balls.Exists(whiteBall => whiteBall.ColorOfTheBall == Ball.BallColor.White) &&
            balls.Exists(greenBall => greenBall.ColorOfTheBall == Ball.BallColor.Green))
            return false;
        else return true;
    }
}
