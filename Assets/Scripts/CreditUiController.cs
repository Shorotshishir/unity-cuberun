using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreditUiController : MonoBehaviour
{
    private void OnEnable()
    {
        var menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        var toMainMenuButton = root.Q<Button>("btn_credit_to_menu");
        toMainMenuButton.clicked += OnClickBackToMain;
    }

    private void OnClickBackToMain()
    {
        GetComponent<Credits>().BackToStart();
    }
}
