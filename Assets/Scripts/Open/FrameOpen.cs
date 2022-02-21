using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameOpen : MonoBehaviour, Interaction
{
	[SerializeField] private SoundScriptableOb soundScriptableOb;
	[SerializeField] private Animator frameOpenAnimator;
	public bool _isOpened;
	[SerializeField] private GameObject player;
	private AudioSource audioSource;
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
		audioSource.clip = soundScriptableOb.GetAudio(AudioType.street);
		_isOpened = false;
	}

	public void Interract()
	{
		if (_isOpened == false)
		{
			StartCoroutine(opening());
		}
		else
		{
			StartCoroutine(closing());
		}
	}
	
	public void ClosingLaptop()
	{
		StartCoroutine(closing());
	}
	IEnumerator opening()
	{
		frameOpenAnimator.Play("HadleAnim");
		_isOpened = true;
		yield return new WaitForSeconds(1f);
		frameOpenAnimator.Play("FrameOpen");
		audioSource.Play();
	}

	IEnumerator closing()
	{
		frameOpenAnimator.Play("FrameClose");
		yield return new WaitForSeconds(1f);
		print("you are closing the laptop");		
		_isOpened = false;
		audioSource.Stop();	
	}

 
}

