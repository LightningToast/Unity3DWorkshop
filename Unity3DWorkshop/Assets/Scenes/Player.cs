using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    Rigidbody rb;
    public float speed = 2f;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        //print("This is start");
	}
	
	// Update is called once per frame
	void Update () {
        //print("This is update");

        if(Input.GetKey("a")) {
            //print("a is down!");
            rb.AddForce(-Vector3.right*speed);
        }
        if (Input.GetKey("d"))
        {

            rb.AddForce(Vector3.right * speed);
        }
    }
}
