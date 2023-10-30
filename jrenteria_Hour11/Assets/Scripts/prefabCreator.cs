using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabCreator : MonoBehaviour
{
    public GameObject Stickie;
    public Vector3 spawnValues;

    // Start is called before the first frame update
    void Start()
    {
    for (int i = 1; i <= 5; i++)
    {
            Vector3 spawnposition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1f, Random.Range(-spawnValues.z, spawnValues.z));
            GameObject gameobject = Instantiate<GameObject>(Stickie, spawnposition, Quaternion.identity);
    }
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
