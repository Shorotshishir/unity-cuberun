using System;
using Unity;
using UnityEngine;
using UnityEngine.UI;

public class ScoreViewer : MonoBehaviour
{
    private Text textData;
    private Text HighScore;

    private void OnEnable()
    {
        Score.ScoreData += ShowTimer;
    }

    public void ShowTimer()
    {
#if false
        Debug.Log($"Show timer{Score.Instance.ScoreValue}");
#endif
        GetComponent<Text>().text = $"{Score.Instance.ScoreValue}";
    }

    private void OnDisable()
    {
        Score.ScoreData -= ShowTimer;
    }

    public void ShowLastScore()
    {
        GetComponent<Text>().text = $"Score: {Score.Instance.ScoreValue}";
    }
}