using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectPool", menuName = "ScriptableObject/ObjectPool")]
public class ObjectPoolScriptable : ScriptableObject
{
    public ObstacleMovement ObstaclePerfab;

    [SerializeField]
    private Queue<ObstacleMovement> obstacles = new Queue<ObstacleMovement>();

    private void OnEnable()
    {
        hideFlags = HideFlags.DontUnloadUnusedAsset;
        ObstacleMovement.BackToPool += ReturnToPool;
    }

    public ObstacleMovement Get()
    {
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

    private void ReturnToPool(ObstacleMovement obstacle)
    {
        obstacle.gameObject.SetActive(false);
        obstacles.Enqueue(obstacle);
    }

    public void Reset()
    {
        obstacles.Clear();
    }
}