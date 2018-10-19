using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMaster : MonoBehaviour {
    Rigidbody rb;
    public float speed = 10f;
    public bool gameOver = false;

    public int score = 0;

    public GameObject scoreMarker;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameOver)
        {
            score = score + 1;
            scoreMarker.GetComponent<TextMesh>().text = "Score: " + score;
            if (Input.GetKey("a"))
            {
                rb.AddForce(-Vector3.right * speed);
            }
            if (Input.GetKey("d"))
            {
                rb.AddForce(Vector3.right * speed);
            }
        }
        else {
            if(Input.GetKeyDown("a")) {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
        if (collision.gameObject.tag == "EnemyMaster")
        {
            gameOver = true;
            scoreMarker.GetComponent<TextMesh>().text = "Game Over!: " + score;
        }
    }
}
