using UnityEngine;

public class AntQueenMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _checkPoints;
    [SerializeField] private float _speed;

    private int _currentCheckPoints = 0;

    void Update()
    {
        if (transform.position == _checkPoints[_currentCheckPoints].position)
        {
            _currentCheckPoints = (_currentCheckPoints + 1) % _checkPoints.Length;
        }

        Move();
        Look();
    }

    protected virtual void Look()
    {
        Vector3 direction = _checkPoints[_currentCheckPoints].position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, _speed * Time.deltaTime);
    }

    protected virtual void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _checkPoints[_currentCheckPoints].position, _speed * Time.deltaTime);
    }
}
