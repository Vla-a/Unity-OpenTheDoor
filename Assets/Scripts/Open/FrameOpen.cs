using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameOpen : MonoBehaviour
{
	[SerializeField] private Animator _LaptopOpen;
	public bool _isOpened;
	[SerializeField] private GameObject player;
	private AudioSource audioSource;
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
		_isOpened = false;
	}

	void OnMouseOver()
	{
		{
			if (player)
			{
				float dist = Vector3.Distance(player.transform.position, transform.position);
				if (dist < 15)
				{
					if (_isOpened == false)
					{

						if (Input.GetMouseButtonDown(0))
						{
							StartCoroutine(opening());
						}
					}
					else
					{
						if (_isOpened == true)
						{
							if (Input.GetMouseButtonDown(0))
							{
								StartCoroutine(closing());
							}
						}

					}

				}
			}

		}

	}
	public void ClosingLaptop()
	{
		StartCoroutine(closing());
	}
	IEnumerator opening()
	{				
		_LaptopOpen.Play("HadleAnim");
		_isOpened = true;
		yield return new WaitForSeconds(1f);
		_LaptopOpen.Play("FrameOpen");
		audioSource.Play();

	}

	IEnumerator closing()
	{
		_LaptopOpen.Play("FrameClose");
		yield return new WaitForSeconds(1f);
		print("you are closing the laptop");		
		//_LaptopOpen.Play("NoHadleAnim");
		_isOpened = false;
		audioSource.Stop();
	
	}

}

