using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public GameObject canvas;
    //public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        canvas.SetActive(true);
        //Invoke("invisible",1f);
    }
    // void invisible()
    // {
    //     Destroy(deathEffect);
    //     Debug.Log("Death prefab lost");
    // }
}
