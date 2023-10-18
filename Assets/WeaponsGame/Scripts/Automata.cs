using System.Collections;
using UnityEngine;

public class Automata : Weapon
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _firePoint;
    private int _bulletCount;
    private int _bulletsInOneShot = 3;
    private float _periodBetweenBullets = 0.5f;

    private IEnumerator OneShoot()
    {
        for (int i = 0; i < _bulletsInOneShot; i++)
        {
            Instantiate(_bulletPrefab, _firePoint.position, Quaternion.identity);
            _bulletCount--;
            yield return new WaitForSeconds(_periodBetweenBullets);
        }
    }
    public void Initialize(Transform firePoint, GameObject bulletPrefab, int bulletCount, int bulletsInOneShot)
    {
        _firePoint = firePoint;
        _bulletPrefab = bulletPrefab;
        _bulletCount = bulletCount;
        _bulletsInOneShot = bulletsInOneShot;
    }

    public override void Shoot()
    {
        if (_bulletCount > 3)
        {
            StartCoroutine(OneShoot());
        }
    }
}
