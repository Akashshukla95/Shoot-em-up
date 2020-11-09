using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playbtn : MonoBehaviour
{
    public GameObject canvas;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void OnClick()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
