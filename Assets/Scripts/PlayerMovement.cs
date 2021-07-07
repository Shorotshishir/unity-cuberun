using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public delegate void PlayerFellOutDelegate(object sender);

    public static event PlayerFellOutDelegate PlayerFellOut;

    public GameManager GameManager;
    public PlayerInput playerInput;

    public Rigidbody rb;
    public float speed = 15f;
    private Vector3 inputMovement;
    private float movementRange;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        //JoyStickController.UpdatePosition += OnUpdatePosition;
    }

    private void OnUpdatePosition(Vector2 pos)
    {
        var joyStickMove = pos.x;
        Debug.Log($"joyStickMove {joyStickMove}");
        if (pos.x != 0)
        {
            Movement(joyStickMove);
        }
    }

    public void OnPlayerMovement(InputAction.CallbackContext value)
    {
        Movement(value.ReadValue<float>());
    }

    public void Movement(float value)
    {
        movementRange = value;
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
        GameManager.EndGame();
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