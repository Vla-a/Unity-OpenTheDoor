using UnityEngine;
using UnityEngine.UI;

public class OpenTextFile : MonoBehaviour
{
    private float clickTime = 0.3f;
    [SerializeField] private GameObject displayInfo;
    [SerializeField] private InputField newText;
    [SerializeField] private Text textInfo;
    public void ShowTextFile()
    {

        if (clickTime > 0)
        {
            if ((Time.realtimeSinceStartup - clickTime) < 0.3f)
            {
                displayInfo.SetActive(true);
            }
            clickTime = Time.realtimeSinceStartup;
        }
    }

    public void CloseTextInfo()
    {
        displayInfo.SetActive(false);
    }

    public void SaveNewText()
    {
        textInfo.text += " " + newText.text;
        newText.text = string.Empty;
    }


}


