using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuberotate : MonoBehaviour
{
    [Range(0,20)]
    public int rotateNum;
    private float iniy;

    void Start()
    {
        iniy = transform.localEulerAngles.y;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0,rotateNum,0) * Time.deltaTime);

        if(transform.localEulerAngles.y > iniy + 30f)
        {
            rotateNum *= -1;
        }
        if(transform.localEulerAngles.y < iniy - 30f)
        {
            rotateNum *= -1;
        }
        
    }
}
