using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public string triggerName;

    public void Start()
    {
        triggerName = gameObject.name; // Get the name of the trigger.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerSphere"))
        {
            Debug.Log("Sphere entered " + triggerName);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerSphere"))
        {
            Debug.Log("Sphere exited " + triggerName);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerSphere"))
        {
            Debug.Log("Sphere stays in " + triggerName);
        }
    }
}
