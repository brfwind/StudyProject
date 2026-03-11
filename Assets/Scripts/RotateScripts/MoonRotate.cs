using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotate : MonoBehaviour
{
    [Range(0,100)]
    public int rotateNum;

    public GameObject earth;

    void Update()
    {
        transform.RotateAround(earth.transform.position,Vector3.up,rotateNum*Time.deltaTime);
    }
}
