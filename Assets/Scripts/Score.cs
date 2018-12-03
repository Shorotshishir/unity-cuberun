using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text ScoreTimer;
    private float startTime;
    //public string minutes;
    //public string seconds;

    // Use this for initialization
    void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        float f = Time.time - startTime;
        string minutes = ((int)f / 60).ToString();
        string seconds = (f % 60).ToString("f3");
        ScoreTimer.text = "Score: " + minutes + " : " + seconds;

    }
}
