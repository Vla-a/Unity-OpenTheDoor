using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveOpen : MonoBehaviour
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
	
	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
		_animator = GetComponent<Animator>();
		
	}
    private void OnTriggerEnter(Collider other)
    {
		playerCamera.SetActive(false);
		camera.SetActive(true);
		Cursor.lockState = CursorLockMode.None;		
	}

    private void OnTriggerStay(Collider other)
	{		
        if (Input.GetKeyDown(KeyCode.E))         
            {
				audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.knob));
				if (input.text == PASWWORD)
				{
				StartCoroutine(correct());
			}
				else StartCoroutine(incorrect());				
			}
	}
	private void OnTriggerExit(Collider other)
	{
		input.text = string.Empty;		
	    _animator.SetBool("isSave", false);
		playerCamera.SetActive(true);
		camera.SetActive(false);
		Cursor.lockState = CursorLockMode.Locked;
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
