using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public ObjectPoolScriptable objectPool;
    public Transform[] spawnpoint;
    public float timeBetweenWave = 3f;
    public bool stop = false;
    private float timeToSpawn = 2f;

    private void FixedUpdate()
    {
        if (stop == false)
        {
            if (Time.time >= timeToSpawn)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + timeBetweenWave;
            }

            if (transform.position.y < -1f)
            {
                Destroy(gameObject);
            }
        }
    }

    private void SpawnBlocks()
    {
        var randomIndex = Random.Range(0, spawnpoint.Length);
        for (var i = 0; i < spawnpoint.Length; ++i)
        {
            if (randomIndex != i)
            {
                var block = objectPool.Get();
                block.transform.position = spawnpoint[i].position;
                block.gameObject.SetActive(true);
            }

            if (stop == true)
            {
                i = -1;
                break;
            }
        }
    }

    private void OnDestroy()
    {
        objectPool.Reset();
    }
}