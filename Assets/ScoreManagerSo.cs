using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/Score", order = 1)]
public class ScoreManagerSo : ScriptableObject
{
    
    
    public string score;

    private void OnEnable()
    {
        hideFlags = HideFlags.DontUnloadUnusedAsset;
    }
    
    public string GetScore()
    {
        return score;
    }

    public void Reset()
    {
        score = string.Empty;
    }
}
