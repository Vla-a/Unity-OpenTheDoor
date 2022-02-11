using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSound : MonoBehaviour
{
    [SerializeField] private SoundScriptableOb soundScriptableOb;
    private AudioSource audioSource;
   
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.klock));
    }  
}
