using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    [SerializeField] private Text score;
    [SerializeField] private Text highScore;
    [SerializeField] private Text time;
    [SerializeField] private Text endScore;
    [SerializeField] private Text endHighScore;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject topBar;
    private float gameTime = 0.0f;
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

    private void Update()
    {
        gameTime += Time.deltaTime;
        score.text = "Score: " + GameManager.instance.score;
        highScore.text = "High Score: " + GameManager.instance.HighScore;
        time.text = "Time: " + gameTime;
    }

    public void displayGameOverScreen()
    {
        endScore.text = GameManager.instance.score.ToString();
        endHighScore.text = GameManager.instance.HighScore.ToString();
        topBar.SetActive(false);
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
