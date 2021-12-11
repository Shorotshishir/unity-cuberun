using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickUi : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}