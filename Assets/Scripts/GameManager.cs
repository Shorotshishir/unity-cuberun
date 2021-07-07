using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "GameManager", menuName = "ScriptableObject/GameManager", order = 1)]
public class GameManager : ScriptableObject
{
    private void OnEnable()
    {
        hideFlags = HideFlags.DontUnloadUnusedAsset;
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