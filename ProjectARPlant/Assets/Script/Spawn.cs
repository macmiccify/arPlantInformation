using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameObject WhatToInstantiate;

    void SpawnObject()
    {
        Instantiate(WhatToInstantiate, transform.position, transform.rotation);
    }
}
