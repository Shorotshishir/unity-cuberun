using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
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
        int randomIndex = Random.Range(0, spawnpoint.Length);
        for (int i = 0; i < spawnpoint.Length; ++i)
        {
            if (randomIndex != i)
            {
                var block = ObjectPool.Instance.Get();
                //var block = objectPool.Get();
                block.transform.position = spawnpoint[i].position;
                block.gameObject.SetActive(true);
            }

            if (stop == true)
            {
                i = 0;
                break;
            }
        }
    }
}