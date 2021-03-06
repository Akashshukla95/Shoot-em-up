﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    //public GameObject bulletPrefab;
    public int damage = 40;
    public LineRenderer lineRenderer;

    // Update is called once per frame
    //void Update()
   // {
        //if(Input.GetButtonDown("Fire1"));
       // {
        //    Shoot();
        //}
    //}
    public void Shooting()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        //Shooting logic
        //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

        if(hitInfo)
        {
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, hitInfo.point);            
        }
        else
        {
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);
        }

        lineRenderer.enabled = true;

        yield return 0;

        lineRenderer.enabled = false;
    }
}
