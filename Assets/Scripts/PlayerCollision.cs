using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public delegate void PlayerCollidedDelegate(object sender);

    public static event PlayerCollidedDelegate PlayerCollided;

    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("obstacle")) return;
        PlayerCollided?.Invoke(this);

        gameManager.EndGame();
    }
}