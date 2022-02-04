using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnterText : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private InputField input;
   
    void Update()
    {
        text.text = input.text;
    }
}
