using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    // Use this for initialization
    private static GameManager _instance;

    private void Awake()
    {
        if (_instance != null && _instance != this)
            Destroy(gameObject);
        else
            _instance = this;

        DontDestroyOnLoad(gameObject);
    }

    public void EndGame()
    {
        Restart();
    }

    private void Restart()
    {
        SceneManager.LoadScene("Credit");
    }
}