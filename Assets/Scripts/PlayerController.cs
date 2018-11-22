using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    private float screenCenterX;

   
    private void OnDisable()
    {
        GameOver();
    }
#if UNITY_STANDALONE || UNITY_WEBPLAYER
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, 0, -rotation);
    }
#elif UNITY_IOS || UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE
    private void Awake()
    {
        screenCenterX = Screen.width * 0.5f;
    }

    void Update()
    {
        float rotation = 0;
        // if there are any touches currently
        if(Input.touchCount > 0)
        {
            // get the first one
            Touch firstTouch = Input.GetTouch(0);
            if(firstTouch.position.x > screenCenterX)
            {
                rotation = 1 * rotationSpeed;

            }
            else if(firstTouch.position.x < screenCenterX)
            {
                rotation = -1 * rotationSpeed;
                
            } 
        }
        rotation *= Time.deltaTime;
        transform.Rotate(0, 0, -rotation);
    }

#endif
void GameOver()
    {
        GameManager.instance.EndGame();
        UIManager.instance.displayGameOverScreen();
    }


}
