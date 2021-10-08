using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Privates Variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizantalInput;
    private float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //This is where we get player input
        horizantalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        //Rotates  the car based  on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizantalInput);
    }
}
