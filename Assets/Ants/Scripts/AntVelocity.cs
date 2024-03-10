using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class AntVelocity : MonoBehaviour
{
    private readonly int Speed = Animator.StringToHash(nameof(Speed));

    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody _rigidbody;

    private float _currentSpeed;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _currentSpeed = _rigidbody.velocity.magnitude;
        _animator.SetFloat(Speed, _currentSpeed);
    }
}
