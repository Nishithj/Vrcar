using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;     // Speed of the car
    public float rotationSpeed = 100f;  // Rotation speed for steering
    
    void Update()
    {
        // Move the car forward and backward with arrow keys
        float moveDirection = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveDirection);

        // Rotate the car left and right
        float turnDirection = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, turnDirection);
    }
}
