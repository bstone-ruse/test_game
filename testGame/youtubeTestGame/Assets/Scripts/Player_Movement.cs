using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public Rigidbody rb; //assign a rigidbody specific components

    public float forwardForce = 200f;
    public float sidewaysForce = 12f;

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");
        //add a force in X, Y, and Z
        //rb.AddForce(0,200,500);

        //use gravity on each object
        //rb.useGravity =false ;
	}
	
	// Update is called once per frame  <--depends on framerate
	void FixedUpdate ()
    {
        //add a forward force on fwd/back z-axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")) //executes when a player presses D
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
        }

        //check if Y-position is 
        if(rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

	}
}
