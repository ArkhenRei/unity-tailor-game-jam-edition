using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class needle_controller : MonoBehaviour
{
    Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("needlekey")) 
        {
            myAnimator.GetComponent<Animator>().enabled = true;
        }
        else 
        {
            myAnimator.GetComponent<Animator>().enabled = false;
        }
    }
}
