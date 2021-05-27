using UnityEngine;

public class Score : Singleton<Score>
{
    private Score instance;

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else
            instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    private float startTime;
    public bool IsTimerRunning { get; set; }
    public string ScoreValue { get; private set; } = string.Empty;

    public delegate void ScoreDataDelegate();

    public static event ScoreDataDelegate ScoreData;

    private void Start()
    {
        startTime = Time.time;
    }

    private void FixedUpdate()
    {
        if (IsTimerRunning)
        {
            var timeRunning = Time.time - startTime;
            var minutes = ((int) timeRunning / 60).ToString();
            var seconds = (timeRunning % 60).ToString("f3");
            ScoreValue = $"{minutes}:{seconds}";
            ScoreData?.Invoke();
        }
    }

    public void ResetTimer()
    {
        startTime = Time.time;
        ScoreValue = string.Empty;
        IsTimerRunning = true;
    }
}