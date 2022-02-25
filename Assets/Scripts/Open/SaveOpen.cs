using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveOpen : MonoBehaviour, Interaction
{
	[SerializeField] private GameObject playerCamera;
	[SerializeField] private GameObject camera;
	[SerializeField] private SoundScriptableOb soundScriptableOb;	
	[SerializeField] private GameObject text;
	[SerializeField] private InputField input;	
	[SerializeField] private Animator animatorHandle;
	private const string PASWWORD = "1508";
	private Animator _animator;
	private AudioSource audioSource;
    private bool openDoor = false;
    private string inputPerson;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();

    }

    public void TouchButtonNumber(string number)
    {
        audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.button));
        inputPerson += number;
        input.text = inputPerson;
    }
    public void Interract()
    {
        if (!openDoor)
        {
            playerCamera.SetActive(false);
        camera.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
        else
        {
            openDoor = false;
            _animator.SetBool("isSave", false);
        }
    }

    public void ClickEnter()
    {
       
            openDoor = true;
            audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.knob));
            if (input.text == PASWWORD)
            {
                StartCoroutine(correct());
                inputPerson = "";
                input.text = "";
            }
             else
             {
                StartCoroutine(incorrect());
                inputPerson = "";
                input.text = "";
             }     
     
    }

    public void ClickCancel()
    {
        input.text = string.Empty;
        _animator.SetBool("isSave", false);
        playerCamera.SetActive(true);
        camera.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        inputPerson = "";
        input.text = "";
    }

    private IEnumerator incorrect()
    {
        text.SetActive(true);
        audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.no));
        yield return new WaitForSeconds(2f);
        text.SetActive(false);
    }
    private IEnumerator correct()
    {
        animatorHandle.SetTrigger("Open");
        yield return new WaitForSeconds(1f);
        playerCamera.SetActive(true);
        camera.SetActive(false);
        audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.door));
        _animator.SetBool("isSave", true);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
