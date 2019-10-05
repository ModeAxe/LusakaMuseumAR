using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    private CanvasGroup fadeGroup;
    //private float fadeInSpeed = 0.33f;

    private void Start()
    {

    }

    private void Update()
    {


        
    }
    public void StartAR()
    {
        SceneManager.LoadScene("Main_1");

    }
    public void Quit()
    {
        Application.Quit();
    }
}
