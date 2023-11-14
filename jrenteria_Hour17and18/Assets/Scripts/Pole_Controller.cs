using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole_Controller : MonoBehaviour
{
    Animator anim;
    void Start()
    {
       anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetTrigger("Color");
        }

        if (Input.GetKey(KeyCode.S))
        {
            anim.SetTrigger("Rotate");
        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetTrigger("Scale");
        }
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetTrigger("Position");
        }
    }
}
