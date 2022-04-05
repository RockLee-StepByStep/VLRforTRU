using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassOfMicroscop : MonoBehaviour
{

   
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void ActiveGlass()
    {
        gameObject.SetActive(true);  
    }
    public void DeactivateGlass()
    {
        gameObject.SetActive(false);
    }
}
