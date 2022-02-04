using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveOpen : MonoBehaviour
{	
	[SerializeField] private SoundScriptableOb soundScriptableOb;
	[SerializeField] private GameObject panel;
	[SerializeField] private GameObject text;
	[SerializeField] private TMP_InputField input;
	private const string PASWWORD = "123";
	private Animator _animator;
	private AudioSource audioSource;
	
	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
		_animator = GetComponent<Animator>();
	}
	private void OnTriggerStay(Collider other)
	{
		panel.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
			audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.knob));
			if (input.text == PASWWORD)
            {
				audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.door));
				_animator.SetBool("isSave", true);
				panel.SetActive(false);
			}				
			else StartCoroutine(incorrect());
		}
	}
	private void OnTriggerExit(Collider other)
	{
		input.text = "";
		panel.SetActive(false);
		_animator.SetBool("isSave", false);
	}

	private IEnumerator incorrect()
	{
		text.SetActive(true);
		yield return new WaitForSeconds(2f);
		text.SetActive(false);
	}
}
