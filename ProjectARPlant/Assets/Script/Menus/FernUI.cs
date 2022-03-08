using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FernUI : MonoBehaviour
{
    public void OnClick_back()
    {
        MenuManager.OpenMenu(Menu.SCAN_UI, gameObject);

    }
    public void OpenBrowserFern()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Nephrolepis_exaltata");
    }
}
