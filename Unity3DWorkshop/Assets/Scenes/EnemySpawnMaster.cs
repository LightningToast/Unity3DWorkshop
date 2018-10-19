using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnMaster : MonoBehaviour {
    public GameObject enemyPrefab;
    int spawnCount;
    public int spawnThreshold = 50;
    public float xRange = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        spawnCount = spawnCount + 1;
        if(spawnCount > spawnThreshold) {
            Spawn();
            spawnCount = 0;
        }
	}

    void Spawn () {
        Vector3 spawnPos = transform.position;
        spawnPos.x = Random.Range(-xRange, xRange);
        GameObject obj = (GameObject)Instantiate(enemyPrefab, spawnPos, transform.rotation);

        Destroy(obj, 20);
    }
}
