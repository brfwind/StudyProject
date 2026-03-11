using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Range(0, 10)]
    public int num;
    public GameObject cube;
    private Vector3 pos;
    private Vector3 poss;

    void Start()
    {
        poss = this.transform.position;
        pos = this.transform.localScale;

        for (int i = 0; i < num - 1; i++)
        {
            GameObject newGO = Instantiate(cube);
            poss += Vector3.down;
            newGO.transform.localPosition = poss;
            pos.x += 1f;
            pos.z += 1f;
            newGO.transform.localScale = pos;
        }
    }
}
