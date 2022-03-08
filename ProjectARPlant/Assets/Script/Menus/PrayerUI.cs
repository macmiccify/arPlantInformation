using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PrayerUI : MonoBehaviour
{
    public void OnClick_back()
    {
        MenuManager.OpenMenu(Menu.SCAN_UI, gameObject);

    }
    public void OpenBrowserPrayer()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Maranta_leuconeura");
    }
}
