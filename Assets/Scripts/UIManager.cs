using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        DontDestroyOnLoad(_instance);


    }

	void Update () {
		
	}

    public void displayGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }
}
