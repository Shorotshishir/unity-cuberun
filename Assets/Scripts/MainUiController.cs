using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainUiController : MonoBehaviour
{
    private void OnEnable()
    {
        var menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        var startButton = root.Q<Button>("btn_menu_start");
        var quitButton = root.Q<Button>("btn_menu_quit");
        
        startButton.clicked += OnStartClicked;
        quitButton.clicked += OnQuitClicked;
    }

    private void OnQuitClicked()
    {
        Debug.Log("this is quit");
        GetComponent<Menu>().QuitGame();

    }

    private void OnStartClicked()
    {
        Debug.Log("this is start");

        GetComponent<Menu>().StartScreen();
    }
}
