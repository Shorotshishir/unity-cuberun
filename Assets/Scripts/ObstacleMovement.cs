using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 100f;
    private GameObject spawner;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawner = GameObject.Find("blockSpawner");
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        if (transform.position.z < -49.5f)
        {
            ObjectPool.Instance.ReturnToPool(this);
            //var objectPool = spawner.GetComponent<BlockSpawner>().objectPool;
            //objectPool.ReturnToPool(this);
        }
    }
}