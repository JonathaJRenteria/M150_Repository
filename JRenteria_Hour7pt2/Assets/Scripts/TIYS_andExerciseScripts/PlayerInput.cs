using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
   
    void Start()
    {

    }

  
    void Update()
    {
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
        bool isKeyDownK = Input.GetKey(KeyCode.K);

        if (isKeyDownK)
        {
            print("The K key is currently pressed.");
        }
        if (Input.GetKey(KeyCode.M))
        {
            print("The 'M' key is pressed down.");
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            print("The '0' key was pressed.");
        }




        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

        if (mxVal != 0)
        {
            print("Mouse X movement selected: " + mxVal);
        }
        if (myVal != 0)
        {
            print("Mouse Y movement selected: " + myVal);
        }
    }
}
