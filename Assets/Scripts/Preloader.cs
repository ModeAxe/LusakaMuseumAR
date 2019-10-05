using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preloader : MonoBehaviour {

    public CanvasGroup fadeGroup;
    float loadTime;
    float minimumLogoTime = 3.0f;

    private void Start()
    {
        fadeGroup = FindObjectOfType<CanvasGroup>();

        fadeGroup.alpha = 1;

        //Preload Stuff
        //$$

        if(Time.time < minimumLogoTime)
        {
            loadTime = minimumLogoTime;
        }
        else
        {
            loadTime = Time.time;
        }

    }

    private void Update()
    {
        if(Time.time < minimumLogoTime)
        {
            fadeGroup.alpha = 1 - Time.time;
        }

        if(loadTime != 0 && Time.time > minimumLogoTime)
        {
            fadeGroup.alpha = Time.time - minimumLogoTime;

            if(fadeGroup.alpha >= 1)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
