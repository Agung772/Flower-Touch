using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool sceneGameplay;
    public Animator animatorGameplayUI;
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        if (sceneGameplay)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                animatorGameplayUI.SetTrigger("Start");
            }
        }
    }

    public void ExitGameplayUI()
    {
        animatorGameplayUI.SetTrigger("Exit");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
