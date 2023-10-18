using System.Collections.Generic;
using UnityEngine;

public class WeaponExample : MonoBehaviour
{
    [SerializeField] private Automata _automata;
    [SerializeField] private InfinityAmmoPistol _infinityAmmoPistol;
    [SerializeField] private Pistol _pistol;

    [SerializeField] private Transform _firePoint;
    [SerializeField] private GameObject _bulletPrefab;
    private Weapon _currentWeapon;


    private void Awake()
    {
        _infinityAmmoPistol.Initialize(_firePoint,_bulletPrefab);
        _automata.Initialize(_firePoint,_bulletPrefab,50,3);
        _pistol.Initialize(_firePoint, _bulletPrefab, 6);
        _currentWeapon = _pistol;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Выбран автомат");
            _currentWeapon = _automata;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Выбран бесконечный пистолет");
            _currentWeapon = _infinityAmmoPistol;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Выбран пистолет");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _currentWeapon.Shoot();
        }
    }
}
