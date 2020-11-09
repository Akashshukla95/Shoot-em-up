using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playbtn1 : MonoBehaviour
{
    
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0;
    }

    public void OnClick()
    {
        Time.timeScale = 1;
        canvas.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
