using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homewoek4 : MonoBehaviour
{
    public Light li;
    public Light sun;
    public float moveSpeed;
    public float flashSpeed;
    public float sunSpeed;

    void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        if(transform.position.x > 0.6)
            moveSpeed *= -1;
        else if(transform.position.x < 0.4)
            moveSpeed *= -1;

        li.intensity += flashSpeed * Time.deltaTime;
        if(li.intensity > 2.4)
            flashSpeed *= -1;
        else if(li.intensity < 2.0)
            flashSpeed *= -1;

        sun.transform.Rotate(Vector3.forward,sunSpeed * Time.deltaTime,Space.World);
    }
}
