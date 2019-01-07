using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    //public float forwarfForce = 1000f;
    public float sideForce = 500f;
    public float speed = 15f;
    public float mapWidth = 2f;

    public Joystick joystick;
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate () {

        //rb = GetComponent<Rigidbody>();
        //float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float x = joystick.Horizontal * Time.deltaTime * speed;
        Vector3 newPosition = rb.position + Vector3.right * x;
        rb.MovePosition(newPosition);
        if (rb.position.y < -1f)
        {
            Debug.Log("player fell out");
            FindObjectOfType<GameManager>().EndGame();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
}
