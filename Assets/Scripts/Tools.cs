using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class Tools
{
    public static void Sort(this Transform tr)
    {
        List<Transform> list = new List<Transform>();

        for (int i = 0; i < tr.childCount; i++)
        {
            list.Add(tr.GetChild(i));
        }

        list.Sort((a, b) =>
        {
            if (a.name.Length > b.name.Length)
                return 1;
            else
                return -1;
        });

        for(int i = 0;i<tr.childCount;i++)
        {
            list[i].SetSiblingIndex(i);
        }
    }
}
