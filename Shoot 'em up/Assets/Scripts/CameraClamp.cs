using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, -8.46f, 3.67f),
        Mathf.Clamp(target.position.y, 5f, -18.2f),transform.position.z);
    }
}
