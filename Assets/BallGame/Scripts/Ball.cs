using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public enum BallColor
    {
        White, Green, Red
    }

    public BallColor ColorOfTheBall; // Цвет этого шарика

    [SerializeField] private WinManager _winManager; // ссылка на WinManager, чтобы удалять из списка 

    private void OnMouseDown()
    {
        _winManager.Balls.Remove(this);
        _winManager.CheckWin();
        Destroy(gameObject);
    }



}
