using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartAndReturn : MonoBehaviour
{ 
    void Awake()
    {
        Time.timeScale = 0;
    }


    public void StopGame()
    {
        Time.timeScale = 0;
    }
    public void StartGame()
    {
        Time.timeScale = 1;
    }

    public void ReturnGame()
    {
        SceneManager.LoadScene(0);
    }
}
