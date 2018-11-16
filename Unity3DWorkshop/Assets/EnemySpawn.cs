using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
    public GameObject enemyTemplate;
    int timer;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (timer > 40) {
            Vector3 pos = transform.position;
            pos.x = pos.x + Random.Range(-5f, 5f);
            Instantiate(enemyTemplate, pos, transform.rotation);
            timer = 0;
        }
        timer = timer + 1;
    }
}
