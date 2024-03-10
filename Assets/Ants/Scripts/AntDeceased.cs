using UnityEngine;

public class AntDeceased : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DeadZone>())
            Destroy(gameObject);
    }
}
