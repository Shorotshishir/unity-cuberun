using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public delegate void PlayerFellOutDelegate();

    public static event PlayerFellOutDelegate PlayerFellOut;
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
        PlayerFellOut?.Invoke();
        GameManager.Instance.EndGame();
    }
}