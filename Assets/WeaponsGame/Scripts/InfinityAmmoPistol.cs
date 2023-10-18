using UnityEngine;

public class InfinityAmmoPistol : Weapon
{
    private GameObject _bulletPrefab;
    private Transform _firePoint;
    public void Initialize(Transform firePoint, GameObject bulletPrefab)
    {
        _firePoint = firePoint;
        _bulletPrefab = bulletPrefab;
    }
    public override void Shoot()
    {
        Instantiate(_bulletPrefab, _firePoint.position, Quaternion.identity);
    }
}
