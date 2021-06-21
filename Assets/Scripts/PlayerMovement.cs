using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public delegate void PlayerFellOutDelegate(object sender);

    public static event PlayerFellOutDelegate PlayerFellOut;

    public PlayerInput playerInput;
    public Rigidbody rb;
    public float speed = 15f;
    private Vector3 inputMovement;
    private float movementRange;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnPlayerMovement(InputAction.CallbackContext value)
    {
        movementRange = value.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        if (inputMovement != null)
        {
            //Debug.Log($"Input {movementRange}");
            var x = movementRange * Time.deltaTime * speed;
            var newPosition = rb.position + Vector3.right * x;
            rb.MovePosition(newPosition);
        }
        if (!(rb.position.y < -1f)) return;
        PlayerFellOut?.Invoke(this);
        GameManager.Instance.EndGame();
#if false
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var newPosition = rb.position + Vector3.right * x;
        rb.MovePosition(newPosition);

        if (!(rb.position.y < -1f)) return;
#if false
        Debug.Log("player fell out");
        Debug.Log($"Score : {Score.Instance.ScoreValue}");
#endif
        PlayerFellOut?.Invoke(this);
        GameManager.Instance.EndGame();
#endif
    }
}