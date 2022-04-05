using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class micrOn : MonoBehaviour
{
    //TurnOnCanvas OnCanvas;
    ManageOfPanel manageOfPanel;
    ZoneActive zoneActive;
    [SerializeField] Canvas canvas;

    private void Start()
    {
        manageOfPanel = GameObject.FindObjectOfType<ManageOfPanel>();
        //panelOne = GameObject.FindObjectOfType<panelOneSwitch>();
        zoneActive = GameObject.FindObjectOfType<ZoneActive>();
        //OnCanvas = GameObject.FindObjectOfType<TurnOnCanvas>();
    }

  private void Update()
    {
        
    } 
      

    public void TurnOnMicr()
    { 
        if (zoneActive.numberOfmaterial[0]==1)
        {
            if (Input.GetMouseButtonDown(0))
            manageOfPanel.turnsList[0].TurnOnCanvasss();
            Debug.Log(777);
        }
      if (zoneActive.numberOfmaterial[1] == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                manageOfPanel.turnsList[1].TurnOnCanvasss();
                Debug.Log(888);
            }
        }
        if (zoneActive.numberOfmaterial[2] == 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                manageOfPanel.turnsList[2].TurnOnCanvasss();
                Debug.Log(999);
            }
        }

       
    }
    public void TurnOffMicr()
    {
        Debug.Log("TestError");
    }
}
