using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _delay = 1f;
    [SerializeField] private float _repeatRate = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(Create), _delay, _repeatRate);
    }

    private void Create()
    {
        int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

        _spawnPoints[spawnPointNumber].CreatePrefab();
    }
}
