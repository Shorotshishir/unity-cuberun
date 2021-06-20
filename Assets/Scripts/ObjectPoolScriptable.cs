using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObstaclePool", menuName = "ScriptableObject/OstaclePool")]
public class ObjectPoolScriptable : ScriptableObject
{
    public ObstacleMovement ObstaclePerfab;

    [SerializeField]
    private Queue<ObstacleMovement> obstacles = new Queue<ObstacleMovement>();

    private void Awake()
    {
        obstacles.Clear();
    }

    public ObstacleMovement Get()
    {
        Debug.Log($"obstacles.Count {obstacles.Count}");
        if (obstacles.Count == 0)
        {
            AddObstacles(1);
        }
        return obstacles.Dequeue();
    }

    private void AddObstacles(int count)
    {
        for (int i = 0; i < count; i++)
        {
            var obstacle = Instantiate(ObstaclePerfab);
            obstacle.gameObject.SetActive(false);
            obstacles.Enqueue(obstacle);
        }
    }

    public void ReturnToPool(ObstacleMovement obstacle)
    {
        obstacle.gameObject.SetActive(false);
        obstacles.Enqueue(obstacle);
    }
}