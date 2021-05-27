using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}