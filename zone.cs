using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zone : MonoBehaviour
{
    public void DiactivateOBJ()
    {
        this.gameObject.SetActive(false);
    }
    public void ActivateOBJ()
    {
        this.gameObject.SetActive(true);
    }
}
