using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunSpeed_ImportantFunction : MonoBehaviour
{
    
    public int runSpeed;
    void Start()
    {
        print("Start runs before an object Updates");
    }

    
    void Update()
    {
        print("This is called once a frame");
    }
}
