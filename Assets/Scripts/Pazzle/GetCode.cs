using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCode : MonoBehaviour
{
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private GameObject camera;
    [SerializeField] private GameObject image;
    [SerializeField] private GameObject pazzle;
    [SerializeField] private GameObject passwordnamber;
    [SerializeField] private SoundScriptableOb soundScriptableOb;
    private AudioSource audioSource;
    private int fullElement;
    public static int myElement;
    private bool isActive = true;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        fullElement = image.transform.childCount;
    }
    
    void Update()
    {
      if(fullElement == myElement)
        {
            if (isActive)
            {
                audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.send));
                isActive = false;
            }
            passwordnamber.SetActive(true);
        }
    }
    public void Exit()
    {
        playerCamera.SetActive(true);
        camera.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public static void AddElement()
    {        
       myElement++;            
    }

    private void OnDestroy()
    {
        myElement = 0;
    }
}
