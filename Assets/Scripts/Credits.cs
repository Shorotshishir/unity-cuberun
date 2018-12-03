using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

	// Use this for initialization
	public void BackToStart()
    {
        SceneManager.LoadScene("Menu");
    }
}
