using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    private float brakes = 0.0f;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Rotates the car based on vertical input
        if (verticalInput != 0)
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        Brake();
    }

    void Brake()
    {
        brakes = 0;
        if (Input.GetKey(KeyCode.Space) == true)
        {
            brakes = 300;
        }
    }
}
