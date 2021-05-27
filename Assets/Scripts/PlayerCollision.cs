using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("obstacle")) return;
        Score.Instance.IsTimerRunning = false;
#if false
        Debug.Log($"Score {Score.Instance.ScoreValue}");
#endif
        GameManager.Instance.EndGame();
    }
}