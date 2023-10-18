using UnityEngine;

public class Pistol : Weapon
{
    private GameObject _bulletPrefab;
    private Transform _firePoint;
    private int _bulletCount;
    public void Initialize(Transform firePoint,GameObject bulletPrefab,int bulletCount) 
    {
        _firePoint = firePoint;
        _bulletPrefab = bulletPrefab;
        _bulletCount = bulletCount;
    }

    public override void Shoot() 
    {
        if (_bulletCount > 0)
        {
            Instantiate(_bulletPrefab, _firePoint.position, Quaternion.identity);
            _bulletCount--;
        }
    }
}
