using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed = 2.5f;

    private Vector3 _direction;

    private void Start()
    {
        //_direction = new Vector3(0, _rb.velocity.y, 0);
    }

    private void FixedUpdate()
    {
        _direction.x = Input.GetAxis("Horizontal") * _speed;
        _direction.z = Input.GetAxis("Vertical") * _speed;
        _direction.y = _rb.velocity.y;

        _rb.velocity = _direction;

        Debug.Log("Velocity Y: " + _rb.velocity.y);
    }
}
