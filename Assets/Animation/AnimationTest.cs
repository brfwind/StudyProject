using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    private Animator animaor;
    
    void Start()
    {
        animaor = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            animaor.SetBool("isRun",true);
        }

        if(animaor.GetBool("isRun"))
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
        
        if(Input.GetKeyUp(KeyCode.W))
        {
            animaor.SetBool("isRun",false);
        }
    }
}
