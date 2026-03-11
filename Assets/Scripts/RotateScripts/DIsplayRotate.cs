using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downrotate : MonoBehaviour
{
    [Range(0,20)]
    public int rotateNum;

    void Update()
    {
        transform.Rotate(new Vector3(0,rotateNum,0) * Time.deltaTime);
    }
}
