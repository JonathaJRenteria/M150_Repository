using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    private float moveSpeed = 2.0f;
    private float rotationSpeed = 2.0f;
    private bool isEnlarged = false;

    // Update is called once per frame
    void Update()
    {
        // Move the cube along the x and z axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Rotate the camera about the x axis (vertical mouse movement)
        float mouseY = Input.GetAxis("Mouse Y");
        Camera.main.transform.Rotate(-mouseY * rotationSpeed, 0, 0);

        // Rotate the cube about the y axis (horizontal mouse movement)
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * rotationSpeed, 0);

        // Toggle scale when the M key is pressed
        if (Input.GetKeyDown(KeyCode.M))
        {
            isEnlarged = !isEnlarged;
            if (isEnlarged)
            {
                transform.localScale = new Vector3(2.0f, 2.0f, 2.0f); // Double in size
            }
            else
            {
                transform.localScale = new Vector3(1.0f, 1.0f, 1.0f); // Back to original size
            }
        }
    }
}

