using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public Transform target;         
    public float cameraSpeed = 100f;   

    private Vector3 localRelativePos;      // 相对于坦克本地坐标系的位置
    private Quaternion relativeRot;   
    private bool isRotating = false;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButtonDown(1))
        {
            // 计算相对于坦克的世界坐标位置偏移
            Vector3 worldOffset = transform.position - target.position;
            // 把世界偏移转换到坦克的本地坐标系中存起来
            localRelativePos = target.InverseTransformDirection(worldOffset);
            
            // 计算相对于坦克的旋转
            relativeRot = Quaternion.Inverse(target.rotation) * transform.rotation;

            isRotating = true;
        }

        if (Input.GetMouseButton(1) && isRotating)
        {
            transform.RotateAround(target.position, Vector3.up, mouseX * cameraSpeed * Time.deltaTime);
        }
        
        if (Input.GetMouseButtonUp(1))
        {
            // 把本地偏移转回世界坐标，加上坦克当前位置
            transform.position = target.position + target.TransformDirection(localRelativePos);
            transform.rotation = target.rotation * relativeRot;
            
            isRotating = false;
        }
    }
}