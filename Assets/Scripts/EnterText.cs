using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnterText : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private InputField input;
    private float clickTime = 0.3f;
    void Update()
    {
        text.text = input.text;
    }

    public void ShowFile()
    {
        if (clickTime > 0)
        {
            if(Time.realtimeSinceStartup - clickTime < 0.3f)
                gameObject.SetActive(true);
            clickTime = Time.realtimeSinceStartup;
        }
    }

}
