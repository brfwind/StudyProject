using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public int bulletSpeed;

    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Target"))
        {
            Destroy(this.gameObject);
        }
    }
}
