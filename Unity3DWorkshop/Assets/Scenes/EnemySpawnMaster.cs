using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnMaster : MonoBehaviour {
    // Enemy to spawn
    public GameObject enemyPrefab;
    // When to spawn
    public int spawnThreshold = 50;
    // Where to spawn
    public float xRange = 5f;

    // Tracking when to spawn
    int spawnCount;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Step 1: Increment the counter
        spawnCount = spawnCount + 1;
        // Step 2: Recognize when to spawn
        if(spawnCount > spawnThreshold) {
            Spawn();
            spawnCount = 0;
        }
	}

    // Step 3: Spawn the enemy
    void Spawn () {
        // Step 4: Spawn in a random location
        Vector3 spawnPos = transform.position;
        spawnPos.x = Random.Range(-xRange, xRange);
        GameObject obj = (GameObject)Instantiate(enemyPrefab, spawnPos, transform.rotation);

        // Step 5: Destroy
        Destroy(obj, 20);
    }
}
