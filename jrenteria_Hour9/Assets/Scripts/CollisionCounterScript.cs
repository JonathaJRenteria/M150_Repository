using UnityEngine;

public class CollisionCounterScript : MonoBehaviour
{
    private int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerSphere"))
        {
            collisionCount++;
            Debug.Log("Sphere collided with this cube " + collisionCount + " times.");
        }
    }
}
