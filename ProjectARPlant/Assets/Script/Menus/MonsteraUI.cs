using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsteraUI : MonoBehaviour
{
    public void OnClick_back()
    {
        MenuManager.OpenMenu(Menu.SCAN_UI, gameObject);

    }
    public void OpenBrowserMonstera()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Monstera_deliciosa");
    }
}
