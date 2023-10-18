using UnityEngine;

public class Traider : MonoBehaviour
{
    [SerializeField] private Player _player;

    private ITrader _traider;

    private void Awake()=> _traider = new TradeFruits();

    private void OnTriggerEnter(Collider other)
    {
        switch (_player.character)
        {
            case Player.Characters.Geralt:
                _traider = new TradeArmor();
                break;        
            case Player.Characters.Dragonborn:
                _traider = new TradeFruits();
                break;
            case Player.Characters.Cat:
                _traider = new TradeNothing();
                break;
            default:
                break;
        }
        _traider.Trade();

    }
}
