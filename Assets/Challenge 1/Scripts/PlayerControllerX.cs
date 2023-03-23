using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    void FixedUpdate()
    {
        // inputs
        bool throtleInput = Input.GetKey(KeyCode.Space);
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        if (throtleInput != false)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * horizontalInput);
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * -horizontalInput);
        }
    }
}
