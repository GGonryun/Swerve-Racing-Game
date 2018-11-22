using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {
    [SerializeField] private GameManager gm;

	void Start () {
        DontDestroyOnLoad(this);
        Instantiate(gm);
	}
    
    public void SetDifficulty(int i)
    {
        GameManager.instance.difficulty = i;
    }

    public void StartGame()
    {
        GameManager.instance.StartGame();
        SceneManager.LoadScene("GameScene");

    }

}
