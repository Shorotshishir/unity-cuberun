using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public delegate void PlayerCollidedDelegate(object sender);

    public static event PlayerCollidedDelegate PlayerCollided;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("obstacle")) return;
        PlayerCollided?.Invoke(this);
        GameManager.Instance.EndGame();
    }
}