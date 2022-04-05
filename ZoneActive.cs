using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneActive : MonoBehaviour
{
  

    zone zone;
    GlassOfMicroscop glass;
    [SerializeField] public int[] numberOfmaterial;



    private void Start()
    {
     numberOfmaterial = new int[3];
       



     glass = GameObject.FindObjectOfType<GlassOfMicroscop>();
     zone = GameObject.FindObjectOfType<zone>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("mineral"))
        {
            returnMat(1);
            numberOfmaterial[0] = 1;
            glass.ActiveGlass();
            zone.DiactivateOBJ();
        }
        else if (other.gameObject.CompareTag("mineralTwo"))
        {
            returnMat(2);
            numberOfmaterial[1] = 2;
            glass.ActiveGlass();
            zone.DiactivateOBJ();
        }
        else if (other.gameObject.CompareTag("mineralTrhee"))
        {
            returnMat(0);
            numberOfmaterial[2] = 3;
            glass.ActiveGlass();
            zone.DiactivateOBJ();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("mineral")|| 
            other.gameObject.CompareTag("mineralTwo")|| 
            other.gameObject.CompareTag("mineralTrhee"))
        {
            for(int i = 0; i < numberOfmaterial.Length; i++)
            {
                numberOfmaterial[i] = 0;
            }
            glass.DeactivateGlass();
            zone.ActivateOBJ();
        }
    }

    public int returnMat(int numberOfMaterial)
    {
        if (numberOfMaterial == 1)
        {
            Debug.Log("MineralOne");
        return 1;
        } else if (numberOfMaterial == 2)
        {
            Debug.Log("MineralTwo");
            return 2;
        }
        Debug.Log("MineralTrhee");
        return 3;        
    }
}
