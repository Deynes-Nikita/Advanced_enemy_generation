using UnityEngine;

public class Ant : MonoBehaviour
{
    [SerializeField] private AntQueen _target;

    public AntQueen Target => _target;

    public void SetParameters(AntQueen target, Material material)
    {
        _target = target;

        gameObject.GetComponentInChildren<Renderer>().material = material;
    }
}
