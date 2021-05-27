using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 15f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var newPosition = rb.position + Vector3.right * x;
        rb.MovePosition(newPosition);

        if (!(rb.position.y < -1f)) return;
#if false
        Debug.Log("player fell out");
        Debug.Log($"Score : {Score.Instance.ScoreValue}");
#endif
        Score.Instance.IsTimerRunning = false;
        GameManager.Instance.EndGame();
    }
}