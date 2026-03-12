using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Homework3 : MonoBehaviour
{
    public GameObject cube;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            MakeACube();
        }
    }

    private void MakeACube()
    {
        Vector3 worldPos1 = transform.TransformPoint(new Vector3(0,0,1));
        Vector3 worldPos2 = transform.TransformPoint(new Vector3(0,0,2));
        Vector3 worldPos3 = transform.TransformPoint(new Vector3(0,0,3));

        Instantiate(cube,worldPos1,Quaternion.identity);
        Instantiate(cube,worldPos2,Quaternion.identity);
        Instantiate(cube,worldPos3,Quaternion.identity);
    }
}
