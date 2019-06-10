using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFuncScript : MonoBehaviour
{
    private bool pauseState = false;

    [SerializeField]
    private GameObject homeButton;

    [SerializeField]
    private Animation[] uiAnime;

    void OnHint()
    {

    }

    void OnReStart()
    {
        SceneManager.LoadScene(3);
    }
    
    void OnOffPause()
    {
        pauseState = !pauseState;

        if (pauseState)
        {
            homeButton.SetActive(false);
            Time.timeScale = 0;
        }
        else
        {
            homeButton.SetActive(true);
            Time.timeScale = 1;
        }
    }

    void BackScene()
    {
        SceneManager.LoadScene(2);
    }

    void GameClearAnime()
    {
        for (int i = 0; i < uiAnime.Length; i++)
            uiAnime[i].Play();
    }
}