using System;
using UnityEngine;

public class Score : MonoBehaviour
{
    public ScoreManagerSo scoreManagerSo;
    private bool IsTimerRunning { get; set; }
    private string _scoreValue = string.Empty;
    private float _startTime;

    private void Start()
    {
        _startTime = Time.time;
        IsTimerRunning = true;
    }

    private void OnEnable()
    {
        PlayerCollision.PlayerCollided += StopTimer;
        PlayerMovement.PlayerFellOut += StopTimer;
    }

    private void StopTimer(object sender)
    {
        Debug.Log($"triggeredBy {sender}");
        IsTimerRunning = false;
    }

    private void FixedUpdate()
    {
        if (!IsTimerRunning) return;
        var timeRunning = Time.time - _startTime;
        var minutes = ((int)timeRunning / 60).ToString();
        var seconds = (timeRunning % 60).ToString("f3");
        _scoreValue = $"{minutes}:{seconds}";
        scoreManagerSo.score = _scoreValue;
    }

    private void OnDisable()
    {
        PlayerCollision.PlayerCollided -= StopTimer;
        PlayerMovement.PlayerFellOut -= StopTimer;
    }
}