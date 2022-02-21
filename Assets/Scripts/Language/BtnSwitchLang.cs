using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnSwitchLang : MonoBehaviour
{
    [SerializeField]
    private LocalizationManager localizationManager;

    public void OnButtonClick()
    {
        localizationManager.CurrentLanguage = name;
        SceneManager.LoadScene("MainMenuScenes");
    }
}
