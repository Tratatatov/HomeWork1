using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    private Rigidbody _bulletRigidbody;
    private void Awake()
    {
        _bulletRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _bulletRigidbody.velocity = Vector3.forward * _speed;    
    }
}
