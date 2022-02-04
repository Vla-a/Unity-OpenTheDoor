using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSound : MonoBehaviour
{
    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); 
    }  
}