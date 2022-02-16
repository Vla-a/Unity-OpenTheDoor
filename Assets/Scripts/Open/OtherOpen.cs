using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherOpen : MonoBehaviour
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

    private void OnTriggerStay(Collider collider)
    { 
        if (collider.tag == "Player")
        {
            if (!flag)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    _animator.SetTrigger("open");
                    flag = true;
                    audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.close));
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    _animator.SetTrigger("open");
                    flag = false;
                    audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.close));
                }
            }
        }       

    }
}
