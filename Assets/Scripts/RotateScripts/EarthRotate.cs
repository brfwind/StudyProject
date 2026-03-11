using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EarthRotate : MonoBehaviour
{
    [Range(0,20)]
    public int rotateNum;

    public GameObject sun;

    void Update()
    {
        transform.RotateAround(sun.transform.position,Vector3.up,rotateNum*Time.deltaTime);
    }
}
