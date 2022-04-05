using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnOnCanvas : MonoBehaviour
{
    Image imageOfMineral;

    private void Start()
    {
        imageOfMineral = GetComponent<Image>();    
    }

    private void Update()
    {
     TurnOffCanvasss();
    }

    public void TurnOnCanvasss()
    {
            imageOfMineral.enabled = true;    
    }
    public void TurnOffCanvasss()
    {
        if (imageOfMineral.enabled)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)){
                imageOfMineral.enabled = false;
                Debug.Log("что-то пошло не так");
            }
        }
        
    }
}
