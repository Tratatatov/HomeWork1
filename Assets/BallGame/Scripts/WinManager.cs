using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour
{
    [SerializeField] private Canvas _winScreen;

    private IWin _currentCondition;

    public List<Ball> Balls;


    // === Выбор режима игры на кнопку ===
    public void AllBalls()
    {
        _currentCondition = new AllBalls(Balls);
    }
    public void OneColor() 
    {
        _currentCondition = new WinOneColor(Balls); 
    }
    
    // Проверка на услове победы
    public void CheckWin()
    {
        if (_currentCondition.isWinner(Balls))
        {
            _winScreen.gameObject.SetActive(true); // Вывести экран победы
        }
    }
}
