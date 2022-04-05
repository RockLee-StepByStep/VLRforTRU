using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightObj : MonoBehaviour
{
    Light lightObj;
    void Start()
    {
       lightObj = GetComponent<Light>();
    }

   
    public void LightOn()
    {
        lightObj.enabled = true;
    }

    public void LightOff()
    { 
        lightObj.enabled = false;
    }
}
