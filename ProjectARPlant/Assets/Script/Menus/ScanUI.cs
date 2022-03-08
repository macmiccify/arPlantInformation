using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanUI : MonoBehaviour
{
    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("Application is exiting!!!");
    }
    public void OnClick_Panel()
    {
        MenuManager.OpenMenu(Menu.SCAN_UI, gameObject);
    }
}

