using UnityEngine;

[RequireComponent(typeof(Ant))]
public class AntMovement : MonoBehaviour
{
    [SerializeField] private Ant _ant;
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;

    private void Start()
    {
        _target = _ant.Target.transform;
    }

    void Update()
    {
        Move();
        Look();
    }

    protected virtual void Look()
    {
        transform.LookAt(_target.position);
    }

    protected virtual void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}
