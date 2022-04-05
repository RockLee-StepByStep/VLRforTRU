using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectedObj : MonoBehaviour
{
    Outline outline;
    public static bool activeObj = true;
    public static bool outlineProperty = true;
    


    private void Start()
    {
        outline = GetComponent<Outline>();
    
    }

    private void Update()
    {
        if (outlineProperty == false)
        {
           
            outline.enabled = false;
        }
    }

    public bool activateObject()
    {
        return activeObj = false;
    }

    public bool OutlineActive()
    {
        return outlineProperty = false;
    }
}
