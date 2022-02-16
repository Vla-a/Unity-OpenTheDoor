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
    [SerializeField] private GameObject imageWin;

    private Animator _animator;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {    
     
        if (Input.GetKeyDown(KeyCode.E))
        {
            audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.knob));      
            if (imageKey.activeSelf == true)
            {
                StartCoroutine(open());
            }
        }        
    }
    private void OnTriggerExit(Collider other)
    {
        _animator.SetBool("isOpen", false);
        imageWin.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    private IEnumerator open()
    {
        audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.door));
        _animator.SetBool("isOpen", true);
        yield return new WaitForSeconds(2f);
        audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.win));
        imageWin.SetActive(true);       
        Cursor.lockState = CursorLockMode.None;
    }
}
