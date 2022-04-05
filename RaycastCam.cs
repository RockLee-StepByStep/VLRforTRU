using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCam : MonoBehaviour
{
    public Transform pointer;
    public LightObj lightObj;
    public micrOn micr;

    // Update is called once per frame
    void LateUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, Vector3.forward * 150,Color.red);

        RaycastHit Hit;
        if(Physics.Raycast(ray,out Hit))
        {
            LightObj currentObj = Hit.collider.gameObject.GetComponent<LightObj>();
            micrOn microon = Hit.collider.gameObject.GetComponent<micrOn>();

            if (currentObj)
            {
                if(lightObj && lightObj != currentObj)
                {
                    lightObj.LightOff();
                }
                lightObj = currentObj;
                currentObj.LightOn();
            }
            else
            {
                if (lightObj)
                {
                    lightObj.LightOff();
                    lightObj = null;
                }
            }


            if (microon)
             {
                 if (micr && micr != microon)
                 {
                     micr.TurnOnMicr();
                 }
                 micr = microon;
                microon.TurnOnMicr();
             }
             else
             {
                 if (micr)
                 {
                     micr.TurnOffMicr();
                     micr = null;
                 }
             }
         }
         else
         {
             if (lightObj)
             {
                 lightObj.LightOff();
                 lightObj = null;
             }
             if (micr)
             {
                 micr.TurnOnMicr();
                 micr = null;
             }
            
        }


    }
}
