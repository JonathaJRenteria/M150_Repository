using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Speed of camera movement
    public float moveSpeed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // Get mouse input for horizontal and vertical movement
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calculate camera's new position based on input
        Vector3 newPosition = transform.position;
        newPosition.x += mouseX * moveSpeed * Time.deltaTime;
        newPosition.y -= mouseY * moveSpeed * Time.deltaTime; // Invert Y-axis for up/down movement

        // Update the camera's position
        transform.position = newPosition;
    }
}
