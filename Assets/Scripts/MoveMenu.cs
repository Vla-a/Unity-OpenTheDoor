using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveMenu : MonoBehaviour
{
    [SerializeField] private GameObject panelMainMenu;
    

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {         
                panelMainMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }   
    }

    public void NoMenu()
    {
        panelMainMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void YesMenu()
    {
        SceneManager.LoadScene("MainMenuScenes");        
    }
}
