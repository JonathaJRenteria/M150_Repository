using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseButtonPress : MonoBehaviour
{
    void Update()
    {
        // Check if the left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            print("Left mouse button is pressed.");
        }

        // Check if the right mouse button is pressed
        if (Input.GetMouseButtonDown(1))
        {
            print("Right mouse button is pressed.");
        }

        // Check if the center mouse button is pressed (usually the mouse wheel click)
        if (Input.GetMouseButtonDown(2))
        {
            print("Center mouse button is pressed.");
        }
    }
}






