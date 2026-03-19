using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework5 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CreateCubes(100000));
        // for(int i = 0;i<100000;i++)
        // {
        //     GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //     obj.transform.position = new Vector3(Random.Range(-100,100),Random.Range(-100,100),Random.Range(-100,100));

        // }
    }

    void Update()
    {
        
    }

    IEnumerator CreateCubes(int num)
    {

        for(int i = 0;i<num;i++)
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.transform.position = new Vector3(Random.Range(-100,100),Random.Range(-100,100),Random.Range(-100,100));
            if(i %1000 == 0)
                yield return null;
        }

        yield break;
    }
}
