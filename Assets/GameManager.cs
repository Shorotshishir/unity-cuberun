using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    // Use this for initialization
    private static GameManager instance;


    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else
            instance = this;

        DontDestroyOnLoad(gameObject);
    }

    public bool GameHasEnded { get; set; }

    public void EndGame()
    {
        if (GameHasEnded) return;
#if false
        Debug.Log("GAME OVER");
#endif
        Restart();
    }

    private void Restart()
    {
        SceneManager.LoadScene("Credit");
    }
}