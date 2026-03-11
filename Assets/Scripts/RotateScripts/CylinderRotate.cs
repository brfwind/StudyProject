using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotate : MonoBehaviour
{
    public float rotateNum;

    void Update()
    {
        transform.Rotate(new Vector3(rotateNum, 0, 0) * Time.deltaTime);

        if (!(transform.localEulerAngles.x >= 350 && transform.localEulerAngles.x <= 360) &&
            transform.localEulerAngles.x >= 10 &&
            rotateNum > 0)
        {
            rotateNum = -rotateNum;
        }
        else if (!(transform.localEulerAngles.x <= 10 && transform.localEulerAngles.x >= 0) &&
                 transform.localEulerAngles.x <= 350 &&
                 rotateNum < 0)
        {
            rotateNum = -rotateNum;
        }

    }
}