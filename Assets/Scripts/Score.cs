using UnityEngine;

public class Score : MonoBehaviour
{
    public ScoreManagerSo scoreManagerSo;
    private bool _isTimerRunning;
    private string _scoreValue = string.Empty;
    private float _startTime;

    private void Start()
    {
        _startTime = Time.time;
        _isTimerRunning = true;
    }

    private void OnEnable()
    {
        PlayerCollision.PlayerCollided += StopTimer;
        PlayerMovement.PlayerFellOut += StopTimer;
    }

    private void StopTimer(object sender)
    {
        Debug.Log($"triggeredBy {sender}");
        _isTimerRunning = false;
    }

    private void FixedUpdate()
    {
        if (!_isTimerRunning) return;
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