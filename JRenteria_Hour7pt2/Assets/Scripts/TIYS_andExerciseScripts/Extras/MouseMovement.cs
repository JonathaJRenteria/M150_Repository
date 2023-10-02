using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    void Update()
    {
        // Get mouse movement along the X and Y axes
        float mouseXMovement = Input.GetAxis("Mouse X"); // Get mouse movement along the X-axis.
        float mouseYMovement = Input.GetAxis("Mouse Y"); // Get mouse movement along the Y-axis.

        // Check if there's mouse movement along the X-axis
        if (mouseXMovement != 0)
        {
            print("Mouse X movement: " + mouseXMovement);
        }

        // Check if there's mouse movement along the Y-axis
        if (mouseYMovement != 0)
        {
            print("Mouse Y movement: " + mouseYMovement);
        }
    }
}
