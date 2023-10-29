using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    public float spacing = 2.0f;

    void Start()
    {
        Vector3 referencePosition = new Vector3(-1.0f, 0.0f, -5.0f);
       
        Vector3 spawnPosition = referencePosition;

        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, spawnPosition, Quaternion.identity);
            spawnPosition.x += spacing;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }

    }
}
