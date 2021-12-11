using System;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public ObjectPoolScriptable objectPool;
    public Rigidbody rb;
    public float forwardForce = 100f;
    private GameObject spawner;

    public delegate void BackToPoolDelegate(ObstacleMovement obstacle);

    public static event BackToPoolDelegate BackToPool;

    //public ReturnToPoolEvent BackToPool;

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
            //ObjectPool.Instance.ReturnToPool(this);
            BackToPool?.Invoke(this);
            //objectPool.ReturnToPool(this);
        }
    }

    /*private void OnDestroy()
    {
        objectPool.Reset();
    }*/
}