using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private AsyncOperation loadingOperation1;
    private AsyncOperation loadingOperation2;
    private bool sceneLoaded2 = false;
    private bool sceneLoaded3 = false;
    private bool scene1unloaded = false;
    private bool scene2unloaded = false;
    [SerializeField] string scene1;
    [SerializeField] string scene2;
    [SerializeField] string scene3;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void LoadNextScene1()
    {
        loadingOperation1 = SceneManager.LoadSceneAsync(scene2, LoadSceneMode.Single);
        loadingOperation1.completed += OnSceneLoaded2;
        //SceneManager.LoadScene(scene2);
    }
    public void LoadNextScene2()
    {
        loadingOperation2 = SceneManager.LoadSceneAsync(scene3, LoadSceneMode.Single);
        loadingOperation2.completed += OnSceneLoaded3;
        //SceneManager.LoadScene(scene3);
    }

    private void OnSceneLoaded2(AsyncOperation asyncOperation)
    {
        //sceneLoaded2 = true;
    }
    private void OnSceneLoaded3(AsyncOperation asyncOperation)
    {
        //sceneLoaded3 = true;
    }
    private void Update()
    {
        if (sceneLoaded2 && !scene1unloaded) // or any condition you prefer for the transition
        {
            //SceneManager.UnloadSceneAsync(scene1);
            SceneManager.UnloadSceneAsync(scene1);
            scene1unloaded = true;
        }
        if (sceneLoaded3 && !scene2unloaded) // or any condition you prefer for the transition
        {
            //SceneManager.UnloadSceneAsync(scene2);
            SceneManager.UnloadSceneAsync(scene2);
            scene2unloaded = true;
        }
    }
}