using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public ScoreManagerSo scoreManagerSo;

    public void StartScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        scoreManagerSo.Reset();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
        Application.Quit ();
#elif UNITY_WEBGL
        Application.OpenURL("https://shorotshishir.github.io/#work");
#endif
    }
}