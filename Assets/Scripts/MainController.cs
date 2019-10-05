using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour {

    public GameObject subMenu;

    public void backToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ToggleSubMenu()
    {
        if (!subMenu.active)
            subMenu.SetActive(true);
        else
            subMenu.SetActive(false);
   }

    public void quit()
    {
        Application.Quit();
    }


}
