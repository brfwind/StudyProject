using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework7 : MonoBehaviour
{
    LineRenderer lineObj2;

    void Start()
    {
        DrawACircle(new Vector3(15, 0, 0), 5, 100);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject obj = new GameObject();
            obj.transform.SetParent(this.transform);
            lineObj2 = obj.AddComponent<LineRenderer>();
            lineObj2.positionCount = 0;

            lineObj2.startWidth = 0.1f;
            lineObj2.endWidth = 0.1f;
            lineObj2.startColor = Color.white;
            lineObj2.endColor = Color.white;
        }

        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;  //屏幕坐标(z为0)
            mousePos.z = 10;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            
            lineObj2.positionCount += 1;
            lineObj2.SetPosition(lineObj2.positionCount - 1,worldPos);
        }
        
    }

    public void DrawACircle(Vector3 center, float radius, int pointNum)
    {
        GameObject obj = new GameObject();
        obj.name = "CircleLine";
        LineRenderer lineObj = obj.AddComponent<LineRenderer>();

        lineObj.loop = true;
        lineObj.positionCount = pointNum;
        float angle = 360f / pointNum;

        for (int i = 0; i < pointNum; i++)
        {
            //四元数乘向量，等于旋转后的新向量（顺序不可颠倒）
            lineObj.SetPosition(i, center + Quaternion.AngleAxis(angle * i, Vector3.up) * Vector3.forward * radius);
        }
    }
}
