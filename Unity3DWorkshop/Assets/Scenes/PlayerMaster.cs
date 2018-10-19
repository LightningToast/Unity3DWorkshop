using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMaster : MonoBehaviour {
    // Private variables
    Rigidbody rb;

    // Public variables
    public float speed = 10f;
    public bool gameOver = false;
    public int score = 0;
    public GameObject scoreMarker;

	// Use this for initialization
	void Start () {
        // Step 2: Get the rigidbody (housekeeping)
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        // Step 6: Game over states
        if (!gameOver)
        {
            // Step 7: Score
            score = score + 1;
            scoreMarker.GetComponent<TextMesh>().text = "Score: " + score;
            // Step 1: recognize key presses
            if (Input.GetKey("a"))
            {
                // print("I am held down!");
                // Step 3: interact with physics
                rb.AddForce(-Vector3.right * speed);
            }
            if (Input.GetKey("d"))
            {
                rb.AddForce(Vector3.right * speed);
            }
        }
        else {
            // Step 8: Reload the scene after game over
            if(Input.GetKeyDown("a")) {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
    }

    // Step 4: Collision detection
    private void OnCollisionEnter(Collision collision)
    {
        // Step 5: Collision logic
        //Destroy(gameObject);
        if (collision.gameObject.tag == "EnemyMaster")
        {
            gameOver = true;
            scoreMarker.GetComponent<TextMesh>().text = "Game Over!: " + score;
        }
    }
}
