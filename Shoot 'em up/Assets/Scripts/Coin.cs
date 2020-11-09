using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //public int coinValue = 1;
    
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //if(other.gameObject.CompareTag("Player"))
        //{
            //ScoreManager.instance.ChangeScore(coinValue);
        //}
        if(col.gameObject.CompareTag("Player"))
        {
        ScoreTextScript.coinAmount += 1;
        Destroy(gameObject);
        }
    }
}
