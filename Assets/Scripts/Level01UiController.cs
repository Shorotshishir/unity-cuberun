using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Level01UiController : MonoBehaviour
{
    private Label _currentTimer;
    public ScoreManagerSo scoreManagerSo;
    private void OnEnable()
    {
        var menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        _currentTimer = root.Q<Label>("lbl_curr_timer");
        _currentTimer.text = $"0:00:00.000";
    }
    
    private void FixedUpdate()
    {
        ShowTimer();
    }

    private void ShowTimer()
    {
        _currentTimer.text = $"{scoreManagerSo.score}";
    }
}