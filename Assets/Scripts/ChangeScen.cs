using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScen : MonoBehaviour
{
    [SerializeField] private string m_Scene;
    [SerializeField] private GameObject m_MyGameObject;
    public void GoToGame()
    {
        StartCoroutine(LoadYourAsyncScene());
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    IEnumerator LoadYourAsyncScene()
    {       
        Scene currentScene = SceneManager.GetActiveScene();

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(m_Scene, LoadSceneMode.Additive);
        
        while (!asyncLoad.isDone)
        {
            yield return null;
        }       
        SceneManager.MoveGameObjectToScene(m_MyGameObject, SceneManager.GetSceneByName(m_Scene));       
        SceneManager.UnloadSceneAsync(currentScene);
    }
}
