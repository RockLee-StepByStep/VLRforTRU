using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animMenu : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

  public void HideMenu()
    {
        Debug.Log("animationHide is work");
        animator.SetBool("HideOpen", true);
    }
    public void OpenMenu()
    {
        Debug.Log("animationOpen is work");
        animator.SetBool("HideOpen", false);
    }
}
