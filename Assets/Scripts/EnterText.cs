using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnterText : MonoBehaviour
{
    [SerializeField] private SoundScriptableOb soundScriptableOb;
    [SerializeField] private Text text;
    [SerializeField] private Text _exseption;
    [SerializeField] private InputField input;
    [SerializeField] private Image imageRiddle;
    [SerializeField] private GameObject number;
    private AudioSource audioSource;
    private const string ANSWER = "87";

    private float clickTime = 0.3f;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();       
    }
    void Update()
    {
        text.text = input.text;
    }

    public void ShowFile()
    {
        if (clickTime > 0)
        {
            if(Time.realtimeSinceStartup - clickTime < 0.3f)
            {
                gameObject.SetActive(true);
                imageRiddle.gameObject.SetActive(false);
            }     
            clickTime = Time.realtimeSinceStartup;
        }        
    }

    public void SaveCloseFile()
    {        
        if (text.text == ANSWER)
        {
            number.SetActive(true);
            gameObject.SetActive(false);
            imageRiddle.gameObject.SetActive(true);
        }
        else StartCoroutine(mistake());        
    }

    public void CloseFile()
    {      
        gameObject.SetActive(false);
        imageRiddle.gameObject.SetActive(true);
    }
    private IEnumerator mistake()
    {
        audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.no));
        _exseption.gameObject.SetActive(true);
        yield return new WaitForSeconds(5f);
        _exseption.gameObject.SetActive(false);
    }
}
