using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    Rigidbody rb;
    DetectedObj DetectedObj;
    zone zone;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        DetectedObj = GetComponent<DetectedObj>();
        zone = GameObject.FindObjectOfType<zone>();
    }

  
    private void OnMouseDrag()
    {
        Vector3 mousePosDrag = new Vector3(Input.mousePosition.x, Input.mousePosition.y , -Camera.main.transform.position.z);

        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosDrag);

        transform.position = objectPosition;

        rb.isKinematic = true;
        zone.ActivateOBJ();
        DetectedObj.activateObject();
        DetectedObj.OutlineActive();
    }


    private void OnMouseUp()
    {
        zone.DiactivateOBJ();
        rb.isKinematic = false;
    }
}
