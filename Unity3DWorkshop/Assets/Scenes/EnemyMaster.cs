using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaster : MonoBehaviour {
    // Enemy speed
    public float enemySpeed = 20f;

    Rigidbody rb;
    // Use this for initialization
    void Start () {
        // Step 1: Get the rigidbody
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        // Step 2: Set the speed
        rb.velocity = -Vector3.forward * enemySpeed;
    }
}
