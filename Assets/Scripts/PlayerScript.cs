﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            DrawOmikuji();
        }
    }

    void DrawOmikuji()
    {
        string omikujiResult = GameObject.Find("OmikujiBox").GetComponent<OmikujiBoxScript>().NotifyOmikujiResult();
        Debug.Log(omikujiResult);
    }
}
