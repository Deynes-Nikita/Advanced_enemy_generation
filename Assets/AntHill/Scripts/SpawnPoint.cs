using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Ant _antPrefab;
    [SerializeField] private Material _antMaterial;
    [SerializeField] private AntQueen _antQueen;

    public void CreatePrefab()
    {
        _antPrefab.SetParameters(_antQueen, _antMaterial);

        float spawnAngleY = Random.Range(0, 360.0f);

        Instantiate(_antPrefab, transform.position, Quaternion.Euler(0, spawnAngleY, 0));
    }
}
