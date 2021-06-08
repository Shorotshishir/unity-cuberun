using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
    public delegate void PlayerCollidedDelegate();

    public static event PlayerCollidedDelegate PlayerCollided;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("obstacle")) return;
        PlayerCollided?.Invoke();
        GameManager.Instance.EndGame();
    }
}