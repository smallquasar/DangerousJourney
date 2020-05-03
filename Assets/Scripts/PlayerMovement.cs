using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed = 3f;

    private Vector3 _direction;

    private void FixedUpdate()
    {
        _direction.z = Input.GetAxis("Horizontal") * _speed;
        _direction.x = Input.GetAxis("Vertical") * (-1) * _speed;
        _direction.y = _rb.velocity.y;

        _rb.velocity = _direction;
    }
}
