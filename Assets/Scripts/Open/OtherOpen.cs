using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherOpen : MonoBehaviour, Interaction
{
    [SerializeField] private SoundScriptableOb soundScriptableOb;
    private AudioSource audioSource;
    private Animator _animator;
    private bool flag = false;

    private void Start()
    {      
        audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }

    public void Interract()
    {
        if (!flag)
        {
            _animator.SetTrigger("open");
            flag = true;
            audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.close));

        }
        if (flag)
        {
            _animator.SetTrigger("open");
            flag = false;
            audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.close));
        }
    }

}
