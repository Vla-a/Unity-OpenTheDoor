using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScen : MonoBehaviour
{
    [SerializeField] private string m_Scene; 
   
    public void ChangeScene()
    {
       SceneManager.LoadScene("Game");
        NoSaveOrSave.NoSaver();
    }
    public void NewChangeScene()
    {
        SceneManager.LoadScene("Game");
        NoSaveOrSave.Saver();
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
