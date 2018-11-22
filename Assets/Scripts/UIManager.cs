using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
    [SerializeField] private GameObject gameOverScreen;
    private static UIManager _instance;

    public static UIManager instance
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
        else if(_instance != this)
        {
            _instance = this;

        }

    }

    public void displayGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
      
            GameManager.instance.StartGame();
            SceneManager.LoadScene("GameScene");
    }

    public void ReturnToMenu()
    {

        SceneManager.LoadScene("OpeningScene");
    }
}
