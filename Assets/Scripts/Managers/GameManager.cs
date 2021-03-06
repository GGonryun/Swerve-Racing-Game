﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public int score;
    public int difficulty;
    [SerializeField] private float currentDifficulty;
    private float highScore = 0;
    public float HighScore
    {
        get
        {
            return highScore;
        }
    }

    [SerializeField] private Transform[] enemies;
    private readonly float spawnTimer = 15f;
    private Coroutine spawner;
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
        

    }

    public void StartGame()
    {
        score = 0;
        currentDifficulty = difficulty;
        rnjesus = new System.Random();
        spawner = StartCoroutine(EnemySpawner());

    }

    public void EndGame()
    {
        if(score > highScore)
        {
            highScore = score;
        }

        StopCoroutine(spawner);

    }

    private IEnumerator EnemySpawner()
    {
        yield return new WaitForSeconds(5.0f);

        while(true)
        {
            yield return new WaitForSeconds(spawnTimer/currentDifficulty);
            int random = rnjesus.Next(1, 5);
            GameObject newEnemy = SelectEnemy(random);
            SpawnEnemy(newEnemy);
            currentDifficulty = Mathf.Clamp(currentDifficulty+.15f, 1f, 30f);
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
                GameObject red = Instantiate(Resources.Load("Prefabs/Units/Red Enemy")) as GameObject;
                return red;
            case 2:
                GameObject blue = Instantiate(Resources.Load("Prefabs/Units/Blue Enemy")) as GameObject;
                return blue;
            case 3:
                GameObject green = Instantiate(Resources.Load("Prefabs/Units/Green Enemy")) as GameObject;
                return green;
            case 4:
                GameObject yellow = Instantiate(Resources.Load("Prefabs/Units/Yellow Enemy")) as GameObject;
                return yellow;
        }
        return null;
        
    }
}
