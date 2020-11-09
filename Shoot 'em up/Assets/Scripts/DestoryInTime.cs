using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryInTime : MonoBehaviour
{
    [SerializeField]
    float destryTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destryTime);
    }
}
