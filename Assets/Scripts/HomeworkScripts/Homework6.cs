using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework6 : MonoBehaviour
{
    IEnumerator Fun()
    {
        print("第一次执行");
        yield return 1;
        print("第二次执行");
        yield return 2;
        print("第三次执行");
        yield return 3;
    }

    private void Start()
    {
        IEnumerator fun = Fun();

        fun.MoveNext();
        print(fun.Current);
        fun.MoveNext();
        print(fun.Current);
    }

    void Update()
    {
        
    }
}
