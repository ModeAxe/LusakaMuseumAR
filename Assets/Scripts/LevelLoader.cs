using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider; 
    public Text loadingPercent;
    public void LoadLevel(string sceneName)
    {
        StartCoroutine(loadAsync(sceneName));
       
    }

    IEnumerator loadAsync (string sceneName) {

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        loadingScreen.SetActive(true);

        
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = progress;
            loadingPercent.text = progress * 100 + "%";
            Debug.Log(progress);

            yield return null;
        }
        

    }
}
