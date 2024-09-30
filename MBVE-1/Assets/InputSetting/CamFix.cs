using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFix : MonoBehaviour
{
    public bool isPrimaryCamera = true; // Flag to determine if this is the primary camera
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 2.0f;

    private void Update()
    {
        if (!isPrimaryCamera)
            return; // Exit the function if this is not the primary camera

        // Get mouse movement
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the camera horizontally
        transform.Rotate(Vector3.up * mouseX * rotationSpeed);

        // Move the camera forwards/backwards
        transform.Translate(Vector3.forward * mouseY * moveSpeed * Time.deltaTime);

        // Hide the cursor
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
