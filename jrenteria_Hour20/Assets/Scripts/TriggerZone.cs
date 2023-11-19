using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    // OnTriggerEnter is called when another collider enters the trigger zone
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
