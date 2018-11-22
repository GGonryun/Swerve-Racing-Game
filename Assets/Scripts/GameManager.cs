using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    [SerializeField] private float spawnTimer;
    [SerializeField] private Transform[] enemies;
    private System.Random rnjesus;

    private static GameManager _instance;
    
    public static GameManager instance
    {
        get
        {
            return _instance;
        }
    }


    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else if (_instance != this)
        {
            _instance = this;
            
        } 
        DontDestroyOnLoad(_instance);

        rnjesus = new System.Random();
        StartCoroutine(EnemySpawner());

    }

    private IEnumerator EnemySpawner()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnTimer);
            int random = rnjesus.Next(1, 4);
            GameObject newEnemy = SelectEnemy(random);
            SpawnEnemy(newEnemy);
        }
    }

    private void SpawnEnemy(GameObject who)
    {
        Vector2 newPosition = new Vector2(Random.Range(-25.0f, 25.0f), Random.Range(-25.0f, 25.0f));
        Vector3 newRotation = new Vector3(0, 0, Random.Range(0, 360.0f));

        who.transform.position = newPosition;
        who.transform.eulerAngles = newRotation;
        who.SetActive(true);


    }
    private GameObject SelectEnemy(int who)
    {
        switch (who)
        {
            case 1:
                GameObject red = Instantiate(Resources.Load("Prefabs/Red Enemy")) as GameObject;
                return red;
            case 2:
                GameObject blue = Instantiate(Resources.Load("Prefabs/Blue Enemy")) as GameObject;
                return blue;
            case 3:
                GameObject green = Instantiate(Resources.Load("Prefabs/Green Enemy")) as GameObject;
                return green;
            case 4:
                GameObject yellow = Instantiate(Resources.Load("Prefabs/Yellow Enemy")) as GameObject;
                return yellow;
        }
        return null;
        
    }
}
