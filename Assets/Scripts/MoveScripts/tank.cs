using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class tank : MonoBehaviour
{
    public int forwardSpeed;
    public int rotateSpeed;
    public int cubeSpeed;
    public int PKSpeed;

    private float speedX;
    private float mouseX;
    private float speedY;
    private float mouseScroll;

    public Transform Cube;
    public Transform PKpos;

    void Update()
    {
        mouseScroll = Input.mouseScrollDelta.y;
        speedX = Input.GetAxis("Vertical");
        speedY = Input.GetAxis("Horizontal");
        mouseX = Input.GetAxis("Mouse X");
        
        transform.Translate(Vector3.forward * speedX * forwardSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * speedY * Time.deltaTime * rotateSpeed * 2);

        if(!Input.GetMouseButton(1))
            Cube.Rotate(Vector3.up * mouseX * Time.deltaTime * cubeSpeed);

        PKpos.Rotate(Vector3.right * mouseScroll * PKSpeed * Time.deltaTime);
    }
}
