using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    

    private void OnDisable()
    {
        GameOver();
    }

    void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, 0, -rotation);
    }

    void GameOver()
    {
        GameManager.instance.EndGame();
        UIManager.instance.displayGameOverScreen();
    }
}
