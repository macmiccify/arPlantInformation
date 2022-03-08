using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainMenu : MonoBehaviour
{
    public void OnClick_Login()
    {
        MenuManager.OpenMenu(Menu.SCAN_UI, gameObject);
    }
}