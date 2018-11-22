using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadGame : MonoBehaviour {
    [SerializeField] private GameManager gm;
    [SerializeField] private Text displayTo;

    void Awake () {
        Instantiate(gm);
    }

    private void Update()
    {
        displayTo.text = "Difficulty: " + GameManager.instance.difficulty;
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
