﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausebtn : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        Time.timeScale = 0;
        canvas.SetActive(true);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
