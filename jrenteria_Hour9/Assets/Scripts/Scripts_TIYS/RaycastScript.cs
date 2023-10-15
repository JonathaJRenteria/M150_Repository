using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dirx = Input.GetAxis("Mouse X");
        float diry = Input.GetAxis("Mouse Y");
        // opposite because we rotate about those axes
        transform.Rotate(diry, -dirx, 0);
        CheckForRaycastHit(); // this will be added in the next step
    }

    void CheckForRaycastHit()
    {
        RaycastHit hit;

        // Perform a raycast from the object's position in the forward direction.
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            // Print the name of the collided object and destroy it.
            print(hit.collider.gameObject.name + " destroyed!");
            Destroy(hit.collider.gameObject);
        }
    }
}
