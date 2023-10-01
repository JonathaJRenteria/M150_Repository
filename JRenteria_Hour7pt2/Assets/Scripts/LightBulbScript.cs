using UnityEngine;

public class LightBulbScript : MonoBehaviour
{
    // Reference to the Light component
    public Light targetLight;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure the targetLight is not null
        if (targetLight == null)
        {
            Debug.LogWarning("No Light component assigned to the script.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the "L" key is pressed
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Toggle the enabled state of the light
            if (targetLight != null)
            {
                targetLight.enabled = !targetLight.enabled;

                // Log the state change to the console
                if (targetLight.enabled)
                {
                    Debug.Log("Light is now ON.");
                }
                else
                {
                    Debug.Log("Light is now OFF.");
                }
            }
        }
    }
}
