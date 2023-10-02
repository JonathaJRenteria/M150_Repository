using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecificKeyInputs : MonoBehaviour
            //PlayerInput
{
    void Start()
    {
        // Initialization code here if needed
    }

    void Update()
    {
        //Reading User Input
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
       
        if (hVal != 0)
        {
            print("Horizontal movement selected: " + hVal);
        }
        if (vVal != 0)
        {
            print("Vertical movement selected: " + vVal);
        }
      
        //Arrow keys, WASD

        //Determines whether the Kkey is currently pressed
        bool isKeyDownK = Input.GetKey(KeyCode.K); //Added K
        //Input.GetKey() tests whether a key was pressed at all.

        if (isKeyDownK) //Added K
        {
            print("K key is currently pressed."); //press K
        }

        //Determines the M key is currently pressed
        if (Input.GetKey(KeyCode.M)) 
        {
            print("The 'M' key is pressed down");
        }

        //Determines whether the 0 key is currently pressed
        if (Input.GetKeyDown(KeyCode.Alpha0)) // Alpha0 detects numeric key 0
            //Input.GetKeyDown tests whether a key was pressed during this frame.
        {
            print("The '0' key was pressed");
        }

        //note: that the M key causes output the entire time it is held,
        //while the O key causes output only when it is first pressed.

    }
}
