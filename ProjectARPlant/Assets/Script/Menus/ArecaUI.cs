using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ArecaUI : MonoBehaviour
{
    public void OnClick_back()
    {
        MenuManager.OpenMenu(Menu.SCAN_UI, gameObject);

    }
    public void OpenBrowserPalm()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Dypsis_lutescens");
    }
}
