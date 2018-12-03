using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

    public ObstacleMovement movement;
    public BlockSpawner spawn;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            //Debug.Log("hit "+ collision.collider.tag);
            FindObjectOfType<GameManager>().EndGame();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
        
    }
}
