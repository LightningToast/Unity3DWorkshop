using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheenewscript : MonoBehaviour {
    public float speed = 10f;
    public GameObject scoreShow;
    int score;
	// Use this for initialization
	void Start () {
        //print("Start");
	}
	
	// Update is called once per frame
	void Update () {
        //print("Update");
        score = score + 1;
        scoreShow.GetComponent<TextMesh>().text = "Score: " + score;
        if (Input.GetKey("w")) {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey("s"))
        {
            GetComponent<Rigidbody>().AddForce(-Vector3.forward * speed);
        }

        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(-Vector3.right * speed);
        }
        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy") {
            scoreShow.GetComponent<TextMesh>().text = "GAME OVER";
            Destroy(gameObject);
        }

    }
}
