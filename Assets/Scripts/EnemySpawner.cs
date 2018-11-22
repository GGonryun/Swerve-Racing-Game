using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    [SerializeField] private GameObject yellowEnemy, redEnemy, blueEnemy, greenEnemy;
    [SerializeField] private ObjectPool yellowEnemyPool, redEnemyPool, blueEnemyPool, greenEnemyPool;
	// Use this for initialization
	void Start () {
		yellowEnemyPool = new ObjectPool(100,yellowEnemy);
        redEnemyPool = new ObjectPool(100, redEnemy);
        blueEnemyPool = new ObjectPool(100, blueEnemy);
        greenEnemyPool = new ObjectPool(100, greenEnemy);

    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("space"))
        {
            yellowEnemyPool.FetchObject().SetActive(true);
        }
    }
}
