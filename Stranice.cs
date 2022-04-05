using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stranice : MonoBehaviour
{
   [SerializeField]public StraniceSwitch[] stranices;

   int currentPage = 0;


   
    public void HidePages()
    {
        for(int i = 0;i < stranices.Length; i++)
        {
            stranices[i].gameObject.SetActive(false);
        }
        currentPage = 0;
    }
    public void NextString()
    {
       
       
        if (currentPage>=0 && currentPage <= 7)
        {
            currentPage++;
                stranices[currentPage].gameObject.SetActive(true);
                Debug.Log($"stranice{currentPage}");

            stranices[currentPage - 1].gameObject.SetActive(false);
        }
    }
    public void PreviousPage()
    {
        if (currentPage >= 1 && currentPage <= 8)
        {
            currentPage--;
            stranices[currentPage].gameObject.SetActive(true);
            Debug.Log($"stranice{currentPage}");

            stranices[currentPage + 1].gameObject.SetActive(false);
        }
    }

}
