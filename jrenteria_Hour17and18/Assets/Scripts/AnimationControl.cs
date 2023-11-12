using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator anim;
    void Start()
    {
       anim = GetComponent<Animator>(); 
    }
    void Update()
    {
        anim.SetFloat("Speed", Input.GetAxis("Vertical"));
        anim.SetFloat("Direction", Input.GetAxis("Horizontal"));
    }
}
