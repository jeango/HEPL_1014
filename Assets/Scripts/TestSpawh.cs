using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawh : MonoBehaviour
{

    public float delay;
    
    private float timer;

    void OnEnable()
    {
        InvokeRepeating("Spawn", 0, delay);
    }

    void OnDisable()
    {
        CancelInvoke("Spawn");
    }
    
    
    void Spawn()
    {
        print("Spawn");
    }
}


