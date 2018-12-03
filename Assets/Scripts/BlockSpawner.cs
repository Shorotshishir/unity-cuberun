using UnityEngine;

public class BlockSpawner : MonoBehaviour {
    public Transform[] spawnpoint;
    public GameObject blockPrefab;

    private float timeToSpawn = 2f;
    public float timeBetweenWave = 3f;
    public bool stop = false;
    // Use this for initialization

    // Update is called once per frame
    void Update () {
        if (stop==false)
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
        else
        {

        }
        
        
    }
    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnpoint.Length);
        for (int i = 0; i < spawnpoint.Length; ++i)
        {
            if (randomIndex != i)
            {
                Debug.Log(spawnpoint.Length+" "+randomIndex + " =>"+i);
                Instantiate(blockPrefab, spawnpoint[i].position, Quaternion.identity );
            }
            if (stop==true)
            {
                break;
            }
        }

    }
    public void crashed(bool v)
    {
        if (v == true)
        {
            stop = true;
        }
    }
    
}
