using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageOfPanel : MonoBehaviour
{
    [SerializeField] TurnOnCanvas[] TurnOns;
    [SerializeField]public List<TurnOnCanvas> turnsList;



    void Start()
    {
        TurnOns = GameObject.FindObjectsOfType<TurnOnCanvas>();
        foreach(TurnOnCanvas turnList in TurnOns)
        {
            turnList.GetComponent<TurnOnCanvas>();
            turnsList.Add(turnList);
        }

    }



}
