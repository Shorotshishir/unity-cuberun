using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void BackToStart()
    {
        SceneManager.LoadScene("Menu");
    }
}