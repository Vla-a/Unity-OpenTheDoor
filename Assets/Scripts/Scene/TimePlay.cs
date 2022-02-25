using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePlay : MonoBehaviour
{
    [SerializeField] Text textTime;
    private int minutes = 0;   
    private int seconds = 0;  
    private float msecs = 0;
    

    void Start()
    {
        if (NoSaveOrSave.isSave)
        {
            PlayerPrefs.GetInt("minutes", 0);
            PlayerPrefs.SetInt("second", 0);
        }

         minutes = PlayerPrefs.GetInt("minutes");
         seconds = PlayerPrefs.GetInt("second"); 

    Debug.Log(seconds);
    }


    void Update()
    {
        msecs += Time.deltaTime;
        if (msecs >= 1.0f)
        {
            msecs -= 1.0f;
            seconds++;
            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }
            }
      
    }
     
    public void SetText()
    {
        textTime.text = minutes.ToString() + ":" + seconds.ToString();
    }
}
