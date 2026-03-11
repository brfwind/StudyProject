using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public int cameraSpeed;
    private float mouseSpeed;

    void Update()
    {
        mouseSpeed = Input.GetAxis("Mouse X");

        this.transform.LookAt(target);

        //按住右键时，以坦克为中心点，y轴为旋转轴，鼠标横向移动为依据，移动摄像机
        if(Input.GetMouseButton(1))
        {
            transform.RotateAround(target.position,Vector3.up,mouseSpeed * Time.deltaTime * cameraSpeed);
        }
    }
}
