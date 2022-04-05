using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MdragMicroscop : MonoBehaviour
{
    Outline outline;
   
   
    void Start()
    {
        outline = GetComponent<Outline>();
    }

    void Update()
    {
        ActiveOutline();
    }

    void ActiveOutline()
    {
        if (DetectedObj.activeObj == false)
        {
            outline.enabled = true;
        }
    }
}
