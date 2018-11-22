using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private float spawnTimer;
    [SerializeField] private Transform[] enemies;

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
   
    }

    private IEnumerator SpawnEnemy()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnTimer);
            Debug.Log("create enemy");
        }
    }
}
