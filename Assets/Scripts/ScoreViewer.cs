using UnityEngine;
using UnityEngine.UI;

public class ScoreViewer : MonoBehaviour
{
    private Text _text;
    public ScoreManagerSo scoreManagerSo;

    private void Start()
    {
        _text = GetComponent<Text>();
        ShowTimer();
    }

    private void FixedUpdate()
    {
        ShowTimer();
    }

    private void ShowTimer()
    {
        _text.text = $"{scoreManagerSo.score}";
    }
}