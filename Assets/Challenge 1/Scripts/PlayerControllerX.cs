using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    public GameObject propeller;
    private float propellerSpeed = 100f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left, verticalInput * rotationSpeed * Time.deltaTime);
        
        // 프로펠러 회전
        propeller.transform.Rotate(Vector3.forward, propellerSpeed * Time.deltaTime);
    }
}
