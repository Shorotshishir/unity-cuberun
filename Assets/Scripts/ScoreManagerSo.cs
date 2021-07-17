using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/Score", order = 1)]
public class ScoreManagerSo : ScriptableObject
{
    public string score;

    private void OnEnable()
    {
        EditorApplication.playModeStateChanged += TotalReset;
        hideFlags = HideFlags.DontUnloadUnusedAsset;
#if UNITY_WEBGL
        Application.targetFrameRate = -1;
#endif
    }

    private void TotalReset(PlayModeStateChange state)
    {
        switch (state)
        {
            case PlayModeStateChange.EnteredEditMode:
                break;

            case PlayModeStateChange.ExitingEditMode:
                break;

            case PlayModeStateChange.EnteredPlayMode:
                break;

            case PlayModeStateChange.ExitingPlayMode:
                Reset();
                break;

            default:
                break;
        }
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