using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class MenuManager 
{
    public static bool isInitialised {get; private set; }
    public static GameObject mainMenu, scanUI, arecaUI, bambooUI, fernUI, monsteraUI, prayerUI;
    public static void Init()
    {
       GameObject canvas = GameObject.Find("Canvas");
       mainMenu = canvas.transform.Find("MenuUI").gameObject;
       scanUI = canvas.transform.Find("ScanUI").gameObject;
       arecaUI = canvas.transform.Find("ArecaUI").gameObject;
       //bambooUI = canvas.transform.Find("BambooUI").gameObject;
       //fernUI = canvas.transform.Find("FernUI").gameObject;
       //monsteraUI = canvas.transform.Find("MonsteraUI").gameObject;
       //prayerUI = canvas.transform.Find("PrayerUI").gameObject;
       isInitialised = true;
    }
   public static void OpenMenu(Menu menu, GameObject callingMenu)
   {
       if(!isInitialised)
            Init();

       switch(menu)
       {
           case Menu.MAIN_MENU:
                mainMenu.SetActive(true);
                break;
           case Menu.SCAN_UI:
                scanUI.SetActive(true);
                break;
            case Menu.ARECA_UI:
                arecaUI.SetActive(true);
                break;
            case Menu.BAMBOO_UI:
                bambooUI.SetActive(true);
                break;
            case Menu.FERN_UI:
                fernUI.SetActive(true);
                break;
            case Menu.MONSTERA_UI:
                monsteraUI.SetActive(true);
                break;
            case Menu.PRAYER_UI:
                prayerUI.SetActive(true);
                break;
       }
       callingMenu.SetActive(false);
   } 
}
