using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenDoor : MonoBehaviour, Interaction
{    
    [SerializeField] private SoundScriptableOb soundScriptableOb;
    [SerializeField] private Inventaries inventaries;
    [SerializeField] private GameObject imageWin;
    private bool isOpen;
    private Animator _animator;
    private AudioSource audioSource;

    private void Start()
    {
       
        audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }

    public void Interract()
    {
        if (!isOpen)
        {
            audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.knob));
            if (inventaries.inventaryTypes.Contains(InventaryType.key))
            {

                StartCoroutine(open());
            }
        }
        if (isOpen)
        {
            _animator.SetBool("isOpen", false);
            imageWin.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            isOpen = false;
        }
    }  

    private IEnumerator open()
    {
        audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.door));
        _animator.SetBool("isOpen", true);
        yield return new WaitForSeconds(2f);
        audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.win));
        imageWin.SetActive(true);       
        Cursor.lockState = CursorLockMode.None;
        isOpen = true;
    }
 
}
