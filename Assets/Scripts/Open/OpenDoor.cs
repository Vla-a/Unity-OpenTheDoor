using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenDoor : MonoBehaviour
{    
    [SerializeField] private SoundScriptableOb soundScriptableOb;
    [SerializeField] private GameObject imageKey;
    //[SerializeField] private GameObject panel;
    //[SerializeField] private TMP_InputField input; 
    //private const string  PASWWORD = "123";
    private Animator _animator;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {       
        //panel.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.knob));
            //if (input.text == PASWWORD)
            if (imageKey.activeSelf == true)
            {
                audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.door));
                _animator.SetBool("isOpen", true);
            }
        } 
       
    }
    private void OnTriggerExit(Collider other)
    {
        //input.text = "";
        //panel.SetActive(false);
        _animator.SetBool("isOpen", false);
    }
}
