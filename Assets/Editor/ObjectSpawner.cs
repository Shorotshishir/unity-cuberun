using System;
using UnityEditor;
using UnityEngine;
public class ObjectSpawner : EditorWindow
{
    private string objectName = "GameObject";
    private GameObject objectToSpawn;
    private float scale;
    private float spawnRadius = 1f;

    [MenuItem("Tools/Object Spawner")]
    public static void ShowWindow()
    {
        GetWindow(typeof(ObjectSpawner));
    }

    private void OnGUI()
    {
        GUILayout.Label("Spawn New Object", EditorStyles.boldLabel);
        
        objectName = EditorGUILayout.TextField("Name", objectName);
        objectToSpawn = EditorGUILayout.ObjectField(
            "Prefab",
            objectToSpawn,
            typeof(GameObject),
            false
            ) as GameObject;
        scale = EditorGUILayout.FloatField("Scale",scale);
        spawnRadius = EditorGUILayout.Slider(
            "Spawn Radius", 
            spawnRadius, 
            0.5f, 
            3f);

        if (GUILayout.Button("Spawn"))
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        var go = Instantiate(objectToSpawn);
        go.name = objectName;
    }
}
