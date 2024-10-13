using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Reference to the car (the target to follow)
    public Vector3 offset;    // Offset distance between the camera and the car

    void Start()
    {
        // Initialize the offset based on the initial positions of the car and camera
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // Update the camera's position to follow the car with the offset
        transform.position = target.position + offset;
    }
}
