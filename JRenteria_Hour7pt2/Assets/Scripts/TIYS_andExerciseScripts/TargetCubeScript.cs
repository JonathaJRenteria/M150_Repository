using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject target;
    // This is here for reference
    void Start()
    {
     target = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        // Translate the target GameObject along the X-axis
        target.transform.Translate(0.05f, 0f, 0f);
        // Rotate the target GameObject around the Z-axis
        target.transform.Rotate(0f, 0f, 1f);
        // Scale the target GameObject uniformly
        target.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
