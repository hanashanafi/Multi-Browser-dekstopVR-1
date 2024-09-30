using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamXY : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float rotationSpeed = 1f;

    void Update()
    {
        // Calculate the normalized mouse position in the range [-1, 1]
        Vector3 mousePos = Input.mousePosition;
        float xNormalized = (mousePos.x / Screen.width) * 2 - 1;
        float yNormalized = (mousePos.y / Screen.height) * 2 - 1;

        // Calculate the camera's forward and right vectors in world space
        Vector3 forward = transform.forward;
        forward.y = 0; // Ignore the Y component to prevent movement in the Y direction
        Vector3 right = transform.right;

        // Calculate the movement and rotation based on the normalized mouse position
        Vector3 movement = Vector3.zero;
        Vector3 rotation = Vector3.zero;

        // Move forward or backward based on the top and bottom edges of the screen
        if (yNormalized > 0.9f)
            movement = forward * moveSpeed;
        else if (yNormalized < -0.9f)
            movement = -forward * moveSpeed;

        // Rotate left or right based on the left and right edges of the screen
        if (xNormalized > 0.9f)
            rotation = Vector3.up * rotationSpeed;
        else if (xNormalized < -0.9f)
            rotation = -Vector3.up * rotationSpeed;

        // Apply the movement and rotation to the camera
        transform.Translate(movement * Time.deltaTime, Space.World);
        transform.Rotate(rotation * Time.deltaTime, Space.World);
    }
}
