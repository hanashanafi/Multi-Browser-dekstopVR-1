using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraXY : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public float moveSpeed = 1f;

    private float yaw = 0f;
    private float pitch = 0f;

    void Update()
    {
        // Get mouse position in viewport coordinates
        Vector3 mousePosition = Input.mousePosition;
        Vector3 viewportCenter = new Vector3(0.5f, 0.5f, 0f);
        Vector3 viewportMousePosition = new Vector3(mousePosition.x / Screen.width, mousePosition.y / Screen.height, 0f);

        // Rotate camera around Y-axis based on mouse position along left and right screen edges
        if (viewportMousePosition.x <= 0.05f)
        {
            yaw -= rotationSpeed;
        }
        else if (viewportMousePosition.x >= 0.95f)
        {
            yaw += rotationSpeed;
        }

        // Rotate camera around X-axis based on mouse position along top and bottom screen edges
     //   if (viewportMousePosition.y <= 0.05f)
     //   {
     //       pitch += rotationSpeed;
     //   }
     //   else if (viewportMousePosition.y >= 0.95f)
     //   {
     //       pitch -= rotationSpeed;
     //   }

        // Limit pitch to prevent camera from flipping
        pitch = Mathf.Clamp(pitch, -90f, 90f);

        // Update camera rotation
        transform.eulerAngles = new Vector3(pitch, yaw, 0f);
    }
}
