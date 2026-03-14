using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private int blood;

    void Start()
    {
        blood = 3;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            blood--;
        }

        if(blood <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        
    }
}
