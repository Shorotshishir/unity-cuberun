﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        transform.Find("HighScore").GetComponent<ScoreViewer>().ShowLastScore();
        Debug.Log($"Score: {Score.Instance.ScoreValue}");
    }

    public void StartScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Score.Instance.ResetTimer();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}