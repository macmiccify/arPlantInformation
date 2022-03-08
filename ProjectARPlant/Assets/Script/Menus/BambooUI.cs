using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BambooUI: MonoBehaviour
{
   public void OnClick_back()
    {
        MenuManager.OpenMenu(Menu.SCAN_UI, gameObject);

    }
    public void OpenBrowserBamboo()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Dracaena_sanderiana");
    }
}
