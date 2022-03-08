using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawn : MonoBehaviour
{
    public GameObject button;
    void Start()
    {
        button = GameObject.Find("InformationButton");
        Instantiate(button, new Vector3(0,0,0), Quaternion.identity);
    }
    void ButtonClicked()
    {
        button.SetActive(false);
    }
}
